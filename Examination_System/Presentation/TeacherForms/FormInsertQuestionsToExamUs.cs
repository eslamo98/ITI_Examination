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
using ExaminationSystem.Business.ExamQuestionService;
using ExaminationSystem.Business.QuestionService;
using ExaminationSystem.Data_Access.Models;
using ExaminationSystem.Presentation;
using ExaminationSystem.Data_Access;

namespace Examination_System.Presentation.TeacherForms
{
    public partial class FormInsertQuestionsToExamUs : UserControl
    {
        private Exam _exam;
        private QuestionList selectedQuestions = [];
        private QuestionList removedQuestions = [];
        private BindingSource questionsBinding = [];
        private BindingSource examQuestionsBinding = [];
        private int TotalExamQuestions = 0;
        public FormInsertQuestionsToExamUs(Exam exam)
        {
            _exam = exam;

            InitializeComponent();
            SetupDataGridView();
            LoadQuestions();
            LoadExamQuestions();
            LoadQuestionTypes();

            dgvQuestions.CellClick += DgvQuestions_CellClick;
            dgvExams.CellClick += DgvExams_CellClick;
            QuestionTypes.SelectedIndexChanged += CheckedListBox_SelectedIndexChanged;

        }
        private void LoadQuestionTypes()
        {

            QuestionTypes.Items.Clear();

            foreach (QuestionType type in Enum.GetValues<QuestionType>())
            {
                QuestionTypes.Items.Add(type, false);
            }
        }

        private void CheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<QuestionType> selectedTypes = [];

            foreach (var item in QuestionTypes.CheckedItems)
            {
                if (item is QuestionType type)
                {
                    selectedTypes.Add(type);
                }
            }

            if (selectedTypes.Count == 0)
            {
                LoadQuestions();
            }
            else
            {
                LoadQuestions(selectedTypes);
            }
        }
        private void SetupDataGridView()
        {
            if (dgvQuestions.Columns["AddButton"] == null)
            {
                DataGridViewButtonColumn addButtonColumn = new()
                {
                    Name = "AddButton",
                    HeaderText = "Add To Exam",
                    Text = "Add",
                    UseColumnTextForButtonValue = true
                };

                dgvQuestions.Columns.Add(addButtonColumn);
            }
            if (dgvExams.Columns["RemoveButton"] == null)
            {
                DataGridViewButtonColumn removeButtonColumn = new()
                {
                    Name = "RemoveButton",
                    HeaderText = "Remove",
                    Text = "Remove",
                    UseColumnTextForButtonValue = true
                };

                dgvExams.Columns.Add(removeButtonColumn);
            }
        }
        private void LoadQuestions(List<QuestionType>? selectedTypes = null)
        {
            DataTable table = QuestionService.GetAllQuestionsNotInExambyCourseID(_exam.CourseID, _exam.ID, selectedTypes);
            questionsBinding.DataSource = table;
            dgvQuestions.DataSource = questionsBinding;
        }
        private void HideExamColumns()
        {
            string[] hiddenColumns = { "QuestionType", "CourseID", "ExamID", "QuestionID" };
            foreach (DataGridViewColumn column in dgvExams.Columns)
            {
                if (hiddenColumns.Contains(column.Name))
                {
                    column.Visible = false;
                }
            }
        }
        private void LoadExamQuestions()
        {
            DataTable table = QuestionService.GetQuestionsbyExamID(_exam.ID);
            examQuestionsBinding.DataSource = table;
            dgvExams.DataSource = examQuestionsBinding;
            HideExamColumns();
            dgvExams.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            TotalExamQuestions = table.Rows.Count;
        }
        private void DgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TotalExamQuestions < _exam.NoOfQuestions)
            {
                if (e.RowIndex >= 0 && dgvQuestions.Columns[e.ColumnIndex].Name == "AddButton")
                {
                    Question question = new()
                    {
                        ID = Convert.ToInt32(dgvQuestions.Rows[e.RowIndex].Cells["ID"].Value),
                        Body = dgvQuestions.Rows[e.RowIndex].Cells["Body"].Value.ToString(),
                        Marks = Convert.ToInt32(dgvQuestions.Rows[e.RowIndex].Cells["Marks"].Value),

                    };

                    selectedQuestions.Add(question);
                    TotalExamQuestions++;


                    ((DataTable)questionsBinding.DataSource).Rows.RemoveAt(e.RowIndex);
                    DataTable examTable = (DataTable)examQuestionsBinding.DataSource;
                    DataRow newRow = examTable.NewRow();
                    newRow["ID"] = question.ID;
                    newRow["Body"] = question.Body;
                    newRow["Marks"] = question.Marks;

                    examTable.Rows.Add(newRow);

                    dgvQuestions.DataSource = null;
                    dgvQuestions.DataSource = questionsBinding;
                    dgvExams.DataSource = null;
                    dgvExams.DataSource = examQuestionsBinding;
                    HideExamColumns();
                }
            }
            else
            {
                MessageBox.Show($"Total questions exceeded. You can only select up to {_exam.NoOfQuestions} questions.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvExams.Columns[e.ColumnIndex].Name == "RemoveButton")
            {
                Question question = new Question
                {
                    ID = Convert.ToInt32(dgvExams.Rows[e.RowIndex].Cells["ID"].Value),
                    Body = dgvExams.Rows[e.RowIndex].Cells["Body"].Value.ToString(),
                    Marks = Convert.ToInt32(dgvExams.Rows[e.RowIndex].Cells["Marks"].Value),
                };
                removedQuestions.Add(question);
                TotalExamQuestions--;


                ((DataTable)examQuestionsBinding.DataSource).Rows.RemoveAt(e.RowIndex);
                ((DataTable)questionsBinding.DataSource).Rows.Add(question.ID, question.Body, question.Marks);


                dgvExams.DataSource = null;
                dgvExams.DataSource = examQuestionsBinding;

                dgvQuestions.DataSource = null;
                dgvQuestions.DataSource = questionsBinding;

                HideExamColumns();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TotalExamQuestions < _exam.NoOfQuestions)
            {
                MessageBox.Show($"Please select {_exam.NoOfQuestions} questions.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var commonQuestions = selectedQuestions
                .Where(q => removedQuestions.Any(rq => rq.ID == q.ID))
                .ToList();

            foreach (var question in commonQuestions)
            {
                selectedQuestions.RemoveAll(q => q.ID == question.ID);
                removedQuestions.RemoveAll(q => q.ID == question.ID);
            }
;
            if (selectedQuestions.Count > 0)
            {
                selectedQuestions = [.. selectedQuestions.DistinctBy(q => q.ID)];
                ExamQuestionService.SaveExamQuestions(_exam.ID, selectedQuestions);
            }

            if (removedQuestions.Count > 0)
            {
                removedQuestions = [.. removedQuestions.DistinctBy(q => q.ID)];
                foreach (Question question in removedQuestions)
                {
                    ExamQuestionService.DeleteExamQuestion(_exam.ID, question.ID);
                }
            }

            selectedQuestions.Clear();
            removedQuestions.Clear();

            LoadQuestions();
            LoadExamQuestions();
            QuestionList questions = QuestionService.GetQuestionsListbyExamID(_exam.ID);
            DataTable exam = ExamRepository.GetExamById(_exam.ID);
            if (exam.Rows.Count > 0)
            {
                _exam.Marks = Convert.ToInt32(exam.Rows[0]["TotalMarks"]);
            }
            _exam.QuestionList = questions;
            FormExamPreview formExamPreview = new(_exam);
            formExamPreview.ShowDialog();
        }
    }
}