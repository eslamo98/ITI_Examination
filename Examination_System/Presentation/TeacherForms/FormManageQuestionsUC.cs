using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_System.Business.Enums;
using Examination_System.Business;
using ExaminationSystem.Business.AnswerService;
using ExaminationSystem.Business.QuestionService;
using ExaminationSystem.Data_Access.Models;
using ExaminationSystem;
using Examination_System.Presentation.Common;

namespace Examination_System.Presentation.TeacherForms
{
    public partial class FormManageQuestionsUC : UserControl
    {
        private BindingSource questionsBinding = [];
        Course selectedCourse;
        private readonly int teacherID = General.LoggedUser.ID;
        private Dictionary<int, DataGridViewRow> editedRows = new();
        private bool isLoading = true;

        public FormManageQuestionsUC()
        {
            InitializeComponent();
            LoadCourses();

            cmbCourseName.SelectedIndex = -1;
            dgvQuestions.CellClick += dgvQuestions_CellClick;
            dgvQuestions.CellBeginEdit += dgvQuestions_CellBeginEdit;
            dgvQuestions.RowValidated += dgvQuestions_RowValidated;
            dgvQuestions.RowValidating += dgvQuestions_RowValidating;
            cmbCourseName.SelectedIndexChanged += cmbCourseName_SelectedIndexChanged;
            TrueFalseQuestion.CheckedChanged += CheckBoxType_CheckChanged;
            MultiChoiceType.CheckedChanged += CheckBoxType_CheckChanged;
            OneChoiceType.CheckedChanged += CheckBoxType_CheckChanged;
        }
        private void SetupDataGridView()
        {
            if (dgvQuestions.Columns["EditButton"] == null)
            {
                DataGridViewButtonColumn addButtonColumn = new()
                {
                    Name = "EditButton",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };

                dgvQuestions.Columns.Insert(0, addButtonColumn);
            }
            if (dgvQuestions.Columns["RemoveButton"] == null)
            {
                DataGridViewButtonColumn removeButtonColumn = new()
                {
                    Name = "RemoveButton",
                    HeaderText = "Remove",
                    Text = "Remove",
                    UseColumnTextForButtonValue = true
                };

                dgvQuestions.Columns.Insert(1, removeButtonColumn);
            }
        }
        private void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow selectedRow = dgvQuestions.Rows[e.RowIndex];
            string columnName = dgvQuestions.Columns[e.ColumnIndex].Name;
            int questionID = Convert.ToInt32(dgvQuestions.Rows[e.RowIndex].Cells["QuestionID"].Value);

            if (columnName == "EditButton")
            {
                dgvQuestions.ReadOnly = false;
                foreach (DataGridViewRow row in dgvQuestions.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.ReadOnly = true;
                        cell.Style.BackColor = Color.White;
                    }
                }

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    string colName = dgvQuestions.Columns[cell.ColumnIndex].Name;

                    if (colName is "Body" or "Marks" || colName.StartsWith("Answer") || colName.StartsWith("Correct"))
                    {
                        if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()) && cell.Value.ToString() != "No Answer")
                        {
                            cell.ReadOnly = false;
                            cell.Style.BackColor = Color.LightYellow;
                        }
                        else
                        {
                            cell.ReadOnly = true;
                            cell.Style.BackColor = Color.LightGray;
                        }
                    }
                }
                new ToastForm(ToastType.Info, "You can now edit the question!").Show();
            }

            if (columnName == "RemoveButton")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this question?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (cmbCourseName.SelectedIndex == -1)
                    {
                        selectedCourse = null;
                    }
                    QuestionService.DisableQuestionWithID(questionID);
                    LoadQuestions(teacherID, GetSelectedType(), selectedCourse?.ID ?? null);
                }
            }
        }
        private void dgvQuestions_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgvQuestions.Rows[e.RowIndex];
            string columnName = dgvQuestions.Columns[e.ColumnIndex].Name;

            if (!editedRows.ContainsKey(row.Index))
            {
                editedRows[row.Index] = row;
            }

            // Prevent editing answers for True/False questions
            if (row.Cells["QuestionType"].Value.ToString() == "True & False")
            {
                if (columnName.StartsWith("Answer"))
                {
                    new ToastForm(ToastType.Warning, "You cannot edit answers for True/False questions.").Show();
                    e.Cancel = true;
                }
            }

            // Convert "CorrectX" columns into a ComboBox for True/False
            if (columnName.StartsWith("Correct"))
            {
                DataGridViewComboBoxCell comboBoxCell = new();
                comboBoxCell.Items.Add("True");
                comboBoxCell.Items.Add("False");

                string currentValue = row.Cells[columnName].Value?.ToString();
                if (!string.IsNullOrEmpty(currentValue))
                {
                    comboBoxCell.Value = currentValue;
                }

                dgvQuestions.Rows[e.RowIndex].Cells[columnName] = comboBoxCell;
            }

        }

        private void dgvQuestions_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (isLoading) return; // Skip validation during load
            DataGridViewRow row = dgvQuestions.Rows[e.RowIndex];


            // Ignore empty new rows
            if (row.IsNewRow) return;

            if (!ValidateRow(row))
            {
                new ToastForm(ToastType.Warning, "Please fill all required fields correctly before saving.").Show();
                e.Cancel = true; // Prevents leaving the row if invalid
                return;
            }

            if (!editedRows.ContainsKey(row.Index)) return;

            string questionType = row.Cells["QuestionType"].Value?.ToString();
            int correctAnswersCount = 0;

            foreach (DataGridViewColumn col in dgvQuestions.Columns)
            {
                if (col.Name.StartsWith("Correct"))
                {
                    string correctValue = row.Cells[col.Name].Value?.ToString();
                    if (correctValue == "True")
                    {
                        correctAnswersCount++;
                    }
                }
            }

            if ((questionType == "True & False" || questionType == "Single Choice") && correctAnswersCount != 1)
            {
                new ToastForm(ToastType.Warning, "True/False questions must have exactly one correct answer.").Show();
                e.Cancel = true;
                return;
            }

            if ((questionType == "Multiple Choice") && correctAnswersCount < 1)
            {
                new ToastForm(ToastType.Warning, $"{questionType} questions must have at least one correct answer.").Show();
                e.Cancel = true;
                return;
            }
        }

        private void dgvQuestions_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (isLoading || e.RowIndex < 0 || e.RowIndex >= dgvQuestions.Rows.Count) return;

            // Prevent saving when loading data
            if (editedRows.Count == 0) return;
            if (e.RowIndex < 0 || e.RowIndex >= dgvQuestions.Rows.Count) return;

            DataGridViewRow row = dgvQuestions.Rows[e.RowIndex];

            // Save the changes if validation passes
            int questionID = Convert.ToInt32(row.Cells["QuestionID"].Value);
            string body = row.Cells["Body"].Value.ToString();
            int marks = Convert.ToInt32(row.Cells["Marks"].Value);

            // Extract dynamic answers
            AnswerList newAnswers = new AnswerList();
            AnswerList answers = AnswerService.GetAnswerListbyQuestionID(questionID);
            Question question = QuestionService.GetQuestionWithID(questionID);
            question.AnswerList = answers;

            int i = 0;
            foreach (DataGridViewColumn col in dgvQuestions.Columns)
            {
                if (col.Name.StartsWith("Answer"))
                {
                    string answerValue = row.Cells[col.Name].Value?.ToString()?.Trim();
                    if (string.IsNullOrEmpty(answerValue)) continue;

                    Answer answer = (i < answers.Count) ? new Answer { ID = answers[i].ID } : new Answer();
                    answer.AnswerText = row.Cells[col.Name].Value?.ToString() ?? "";

                    // Find corresponding "CorrectX" column
                    string correctColumn = "Correct" + col.Name.Substring(6);
                    if (dgvQuestions.Columns.Contains(correctColumn))
                    {
                        string correctValue = row.Cells[correctColumn].Value?.ToString();
                        answer.IsAnswerCorrect = correctValue == "True";
                    }

                    newAnswers.Add(answer);
                    i++;
                }
            }

            // Update question with new answers
            question.AnswerList = newAnswers;
            bool success = QuestionService.UpdateQuestionWithID(questionID, body, marks, newAnswers);

            if (success)
            {
                new ToastForm(ToastType.Success, "Changes saved successfully!").Show();
                editedRows.Remove(row.Index); // Mark row as saved
            }
            else
            {
                new ToastForm(ToastType.Error, "Error saving changes.").Show();
            }
        }
        private bool ValidateRow(DataGridViewRow row)
        {
            if (row.Cells["Body"].Value == null || string.IsNullOrWhiteSpace(row.Cells["Body"].Value.ToString()))
                return false;

            if (row.Cells["Marks"].Value == null || !int.TryParse(row.Cells["Marks"].Value.ToString(), out _))
                return false;

            return true;
        }
        private void CheckBoxType_CheckChanged(object sender, EventArgs e)
        {
            LoadQuestions(teacherID, GetSelectedType(), selectedCourse?.ID ?? null);
        }
        private List<QuestionType>? GetSelectedType()
        {
            List<QuestionType> selectedTypes = [];
            if (TrueFalseQuestion.Checked)
            {
                selectedTypes.Add(QuestionType.TrueOrFalse);
            }
            else
            {
                selectedTypes.Remove(QuestionType.TrueOrFalse);
            }
            if (MultiChoiceType.Checked)
            {
                selectedTypes.Add(QuestionType.MultipleChoice);
            }
            else
            {
                selectedTypes.Remove(QuestionType.MultipleChoice);
            }
            if (OneChoiceType.Checked)
            {
                selectedTypes.Add(QuestionType.SingleChoice);
            }
            else
            {
                selectedTypes.Remove(QuestionType.SingleChoice);
            }
            return selectedTypes;
        }
        private void LoadCourses()
        {
            cmbCourseName.DataSource = CourseService.GetAllCoursesListWithTeacherID(General.LoggedUser.ID);
            cmbCourseName.DisplayMember = "Name";
            cmbCourseName.ValueMember = "ID";
            cmbCourseName.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new FormAddQuestionWithAnswersUS());
            Hide();
        }
        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourseName.SelectedItem is not null)
            {
                selectedCourse = (Course)cmbCourseName.SelectedItem;
                LoadQuestions(teacherID, GetSelectedType(), selectedCourse.ID);
            }
            else
            {
                selectedCourse = null;  // Ensure it is reset properly
                LoadQuestions(teacherID, GetSelectedType());
            }
        }

        private void LoadQuestions(int teacherID, List<QuestionType>? questionTypes = null, int? CourseID = null)
        {
            isLoading = true;
            DataTable table;
            table = QuestionService.GetQuestionsWithFilters(teacherID, questionTypes, CourseID);
            questionsBinding.DataSource = table;
            dgvQuestions.DataSource = questionsBinding;

            SetupDataGridView();
            isLoading = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            General.LoadUserControl(new FormAddQuestionWithAnswersUS());
            Hide();
        }

        private void TrueFalseQuestion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MultiChoiceType_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OneChoiceType_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbCourseName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeUS w = new WelcomeUS();
            General.LoadUserControl(w);
        }
    }
}
