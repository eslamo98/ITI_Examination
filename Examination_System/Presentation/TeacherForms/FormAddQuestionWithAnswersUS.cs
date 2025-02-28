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
using ExaminationSystem.Business.QuestionAnswerService;
using ExaminationSystem.Data_Access.Models;
using Examination_System.Presentation.Common;

namespace Examination_System.Presentation.TeacherForms
{
    public partial class FormAddQuestionWithAnswersUS : UserControl
    {

        private AnswerList _answers;
        private FlowLayoutPanel MCQAnswerPanel;
        private Button btnAddAnswer;

        public FormAddQuestionWithAnswersUS()
        {
            InitializeComponent();
            _answers = [];
            cmbQuestionTypes.DataSource = Enum.GetValues<QuestionType>();
            cmbQuestionTypes.SelectedIndex = -1;
            cmbQuestionTypes.SelectedIndexChanged += CmbQuestionTypes_SelectedIndexChanged;
            LoadCourses();
        }
        private void LoadCourses()
        {
            cmbCourseName.DataSource = CourseService.GetAllCoursesListWithTeacherID(General.LoggedUser.ID);
            cmbCourseName.DisplayMember = "Name";
            cmbCourseName.ValueMember = "ID";
            cmbCourseName.SelectedIndex = -1;
        }
        private void CmbQuestionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnswerPanel.Controls.Clear();
            _answers.Clear();

            if (cmbQuestionTypes.SelectedItem is not null)
            {
                QuestionType selectedType = (QuestionType)cmbQuestionTypes.SelectedItem;

                switch (selectedType)
                {
                    case QuestionType.TrueOrFalse:
                        FlowLayoutPanel radioPanel = new FlowLayoutPanel()
                        {
                            FlowDirection = FlowDirection.TopDown,
                            AutoSize = true,
                            AutoSizeMode = AutoSizeMode.GrowAndShrink
                        };

                        RadioButton rbTrue = new RadioButton() { Text = "True", Name = "rbTrue" };
                        RadioButton rbFalse = new RadioButton() { Text = "False", Name = "rbFalse" };

                        radioPanel.Controls.Add(rbTrue);
                        radioPanel.Controls.Add(rbFalse);

                        AnswerPanel.Controls.Add(radioPanel);
                        break;

                    case QuestionType.SingleChoice:
                    case QuestionType.MultipleChoice:
                        MCQAnswerPanel = new FlowLayoutPanel()
                        {
                            FlowDirection = FlowDirection.TopDown,
                            AutoSize = true,
                            AutoSizeMode = AutoSizeMode.GrowAndShrink
                        };

                        btnAddAnswer = new Button() { Text = "Add Answer", Width = 80, BackColor = Color.Black, ForeColor = Color.White, Dock = DockStyle.Bottom, Height = 40 };
                        btnAddAnswer.Click += BtnAddAnswer_Click;

                        AnswerPanel.Controls.Clear();
                        AnswerPanel.Controls.Add(MCQAnswerPanel);
                        AnswerPanel.Controls.Add(btnAddAnswer);
                        break;
                }
            }
        }
        private void BtnAddAnswer_Click(object sender, EventArgs e)
        {
            QuestionType selectedType = (QuestionType)cmbQuestionTypes.SelectedItem;

            if (MCQAnswerPanel == null)
                return;

            FlowLayoutPanel answerRow = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(5)
            };

            TextBox txtAnswer = new TextBox() { Width = 200 };

            if (selectedType == QuestionType.SingleChoice)
            {
                RadioButton rbOption = new RadioButton();
                rbOption.Click += (s, ev) =>
                {
                    foreach (Control control in MCQAnswerPanel.Controls)
                    {
                        if (control is FlowLayoutPanel row)
                        {
                            foreach (Control innerControl in row.Controls)
                            {
                                if (innerControl is RadioButton rb && rb != rbOption)
                                {
                                    rb.Checked = false;
                                }
                            }
                        }
                    }
                };
                answerRow.Controls.Add(rbOption);
            }
            else if (selectedType == QuestionType.MultipleChoice)
            {
                CheckBox chkOption = new CheckBox();
                answerRow.Controls.Add(chkOption);
            }

            answerRow.Controls.Add(txtAnswer);


            Button btnDelete = new Button() { Text = "x", Width = 30, BackColor = Color.DarkRed, ForeColor = Color.White, Height = 30 };
            btnDelete.Click += (s, ev) =>
            {
                MCQAnswerPanel.Controls.Remove(answerRow);
                answerRow.Dispose();
            };

            answerRow.Controls.Add(btnDelete);

            MCQAnswerPanel.Controls.Add(answerRow);
            MCQAnswerPanel.PerformLayout();

            AnswerPanel.Controls.SetChildIndex(btnAddAnswer, AnswerPanel.Controls.Count - 1);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Question question = GetQuestionFromUI();

            if (question == null || question.AnswerList.Count == 0)
            {
                return;
            }

            bool success = QuestionAnswerService.AddQuestionWithAnswers(question, question.AnswerList);

            if (success)
            {
                new ToastForm(ToastType.Success, "Question saved successfully!").Show();
                ResetForm();
            }
            else
            {
                new ToastForm(ToastType.Error, "Failed to save question.").Show();
            }
        }
        private void ResetForm()
        {
            txtQuestionBody.Text = "";
            cmbQuestionTypes.SelectedIndex = -1;
            cmbCourseName.SelectedIndex = -1;
            MarksUpDown.Value = 1;
            AnswerPanel.Controls.Clear();
            _answers.Clear();
        }
        private AnswerList GetAnswersFromUI()
        {
            AnswerList answers = [];

            QuestionType selectedType = (QuestionType)cmbQuestionTypes.SelectedItem;
            switch (selectedType)
            {
                case QuestionType.TrueOrFalse:
                    FlowLayoutPanel trueFalsePanel = AnswerPanel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                    if (trueFalsePanel != null)
                    {
                        RadioButton rbTrue = trueFalsePanel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Text == "True");
                        RadioButton rbFalse = trueFalsePanel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Text == "False");
                        if (rbTrue != null && rbTrue.Checked)
                        {
                            answers.Add(new Answer { AnswerText = "True", IsAnswerCorrect = true });
                            answers.Add(new Answer { AnswerText = "False", IsAnswerCorrect = false });
                        }
                        else if (rbFalse != null && rbFalse.Checked)
                        {
                            answers.Add(new Answer { AnswerText = "True", IsAnswerCorrect = false });
                            answers.Add(new Answer { AnswerText = "False", IsAnswerCorrect = true });
                        }
                        else
                        {
                            new ToastForm(ToastType.Warning, "Please select True or False.").Show();
                            return [];
                        }
                    }
                    break;
                case QuestionType.SingleChoice:
                case QuestionType.MultipleChoice:
                    if (MCQAnswerPanel != null)
                    {
                        bool hasCorrectAnswer = false;
                        foreach (Control control in MCQAnswerPanel.Controls)
                        {
                            if (control is FlowLayoutPanel answerRow)
                            {
                                TextBox txtAnswer = answerRow.Controls.OfType<TextBox>().FirstOrDefault();
                                if (txtAnswer == null || string.IsNullOrWhiteSpace(txtAnswer.Text))
                                    continue;
                                bool isCorrect = false;
                                if (selectedType == QuestionType.SingleChoice)
                                {
                                    RadioButton rbOption = answerRow.Controls.OfType<RadioButton>().FirstOrDefault();
                                    if (rbOption != null && rbOption.Checked)
                                    {
                                        isCorrect = true;
                                        hasCorrectAnswer = true;
                                    }
                                }
                                else if (selectedType == QuestionType.MultipleChoice)
                                {
                                    CheckBox chkOption = answerRow.Controls.OfType<CheckBox>().FirstOrDefault();
                                    if (chkOption != null && chkOption.Checked)
                                    {
                                        isCorrect = true;
                                        hasCorrectAnswer = true;
                                    }
                                }
                                answers.Add(new Answer { AnswerText = txtAnswer.Text, IsAnswerCorrect = isCorrect });
                            }
                        }
                        // Ensure at least two answers are provided
                        if (answers.Count < 2)
                        {
                            new ToastForm(ToastType.Warning, "Please add at least two answers.").Show();
                            return [];
                        }
                        // Ensure at least one correct answer is selected
                        if (!hasCorrectAnswer)
                        {
                            new ToastForm(ToastType.Warning, "Please select at least one correct answer.").Show();
                            return [];
                        }
                    }
                    break;
            }
            return answers;
        }
        private Question GetQuestionFromUI()
        {
            if (cmbCourseName.SelectedItem is not Course selectedCourse)
            {
                new ToastForm(ToastType.Warning, "Please select a course.").Show();
                return null;
            }

            if (cmbQuestionTypes.SelectedItem is null)
            {
                new ToastForm(ToastType.Warning, "Please select a question type.").Show();
                return null;
            }
            QuestionType selectedType = (QuestionType)cmbQuestionTypes.SelectedItem;


            if (string.IsNullOrWhiteSpace(txtQuestionBody.Text))
            {
                new ToastForm(ToastType.Warning, "Please enter a question.").Show();
                return null;
            }

            AnswerList answers = GetAnswersFromUI(); ;

            return new Question
            {
                Body = txtQuestionBody.Text,
                Type = selectedType,
                AnswerList = answers,
                Marks = (int)MarksUpDown.Value,
                CourseID = selectedCourse.ID
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new FormManageQuestions().Show();
        }

        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnswerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            //WelcomeUS w = new WelcomeUS();
            //General.LoadUserControl(w);
        }
    }
}

