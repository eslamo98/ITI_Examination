using Examination_System.Business;
using Examination_System.Business.Enums;
using ExaminationSystem.Business.ExamService;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Examination_System.Presentation.StudentForms
{
    public partial class frmShowStudentExam : Form
    {
        private int studentId;
        private int examId;
        private DataTable dtQuestions;
        private int currentQuestionIndex = 0;
        private System.Windows.Forms.Timer examTimer;
        private DateTime examEndTime;

        public frmShowStudentExam(int _studentId, int _examId)
        {
            InitializeComponent();
            studentId = _studentId;
            examId = _examId;

            // Load exam details and questions
            LoadExamDetails();
            dtQuestions = UserService.GetStudentExamQuestions(studentId, examId);

            // Debug: Check if questions are loaded
            if (dtQuestions.Rows.Count == 0)
            {
                MessageBox.Show("No questions found for this exam.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LoadQuestion(currentQuestionIndex);

            // Initialize and start the exam timer
            InitializeTimer();
        }

        private void LoadExamDetails()
        {
            DataTable exam = ExamService.GetExamById(examId);
            if (exam.Rows.Count > 0)
            {
                lb_examtitle.Text = $"Exam: {exam.Rows[0]["ExamType"]}";
                examEndTime = DateTime.Now.AddMinutes(Convert.ToInt32(exam.Rows[0]["Duration"]));
                //lb_timer.Text = $"Time Remaining: {examEndTime.Subtract(DateTime.Now):hh\\:mm\\:ss}";
            }
        }

        private void InitializeTimer()
        {
            examTimer = new System.Windows.Forms.Timer();
            examTimer.Interval = 1000; // 1 second
            examTimer.Tick += ExamTimer_Tick;
            examTimer.Start();
        }

        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = examEndTime.Subtract(DateTime.Now);
            //lb_timer.Text = $"Time Remaining: {remainingTime:hh\\:mm\\:ss}";

            if (remainingTime.TotalSeconds <= 0)
            {
                examTimer.Stop();
                MessageBox.Show("Time's up! The exam has ended.", "Time Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void LoadQuestion(int questionIndex)
        {
            if (questionIndex < 0 || questionIndex >= dtQuestions.Rows.Count)
            {
                MessageBox.Show("Invalid question index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow questionRow = dtQuestions.Rows[questionIndex];
            int questionId = Convert.ToInt32(questionRow["Id"]);
            string questionText = questionRow["Body"].ToString();
            QuestionType questionType = (QuestionType)(Byte)questionRow["QuestionType"];

            // Clear previous question controls
            flowLayoutPanelQuestions.Controls.Clear();

            // Display the question
            Label lblQuestion = new Label
            {
                Text = questionText,
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold),
                Margin = new Padding(10)
            };
            flowLayoutPanelQuestions.Controls.Add(lblQuestion);

            // Load answers for the question
            LoadAnswers(questionId, questionType);

            // Add navigation buttons
            Button btnPrevious = new Button { Text = "Previous", Enabled = (currentQuestionIndex > 0) };
            Button btnNext = new Button { Text = "Next", Enabled = (currentQuestionIndex < dtQuestions.Rows.Count - 1) };
            Button btnSubmitAnswer = new Button { Text = "Submit Answer" };

            btnPrevious.Click += (s, e) => { currentQuestionIndex--; LoadQuestion(currentQuestionIndex); };
            btnNext.Click += (s, e) => { currentQuestionIndex++; LoadQuestion(currentQuestionIndex); };
            btnSubmitAnswer.Click += (s, e) => SubmitAnswer(questionId);

            FlowLayoutPanel navigationPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                Margin = new Padding(10)
            };
            navigationPanel.Controls.Add(btnPrevious);
            navigationPanel.Controls.Add(btnNext);
            navigationPanel.Controls.Add(btnSubmitAnswer);

            flowLayoutPanelQuestions.Controls.Add(navigationPanel);

            // Update progress label
            //lb_progress.Text = $"Question {currentQuestionIndex + 1} of {dtQuestions.Rows.Count}";
        }

        private void LoadAnswers(int questionId, QuestionType questionType)
        {
            DataTable dtAnswers = UserService.GetStudentExamQuestionAnswers(questionId);

            // Debug: Check if answers are loaded
            if (dtAnswers.Rows.Count == 0)
            {
                MessageBox.Show("No answers found for this question.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (questionType == QuestionType.SingleChoice || questionType == QuestionType.TrueOrFalse)
            {
                foreach (DataRow answerRow in dtAnswers.Rows)
                {
                    RadioButton radio = new RadioButton
                    {
                        Text = answerRow["AnswerText"].ToString(),
                        Tag = answerRow["Id"], // Store AnswerId in Tag
                        AutoSize = true,
                        Margin = new Padding(10)
                    };
                    flowLayoutPanelQuestions.Controls.Add(radio);
                }
            }
            else if (questionType == QuestionType.MultipleChoice)
            {
                foreach (DataRow answerRow in dtAnswers.Rows)
                {
                    CheckBox checkBox = new CheckBox
                    {
                        Text = answerRow["AnswerText"].ToString(),
                        Tag = answerRow["Id"], // Store AnswerId in Tag
                        AutoSize = true,
                        Margin = new Padding(10)
                    };
                    flowLayoutPanelQuestions.Controls.Add(checkBox);
                }
            }
        }

        private void SubmitAnswer(int questionId)
        {
            // Get the selected answer(s)
            var selectedAnswers = flowLayoutPanelQuestions.Controls
                .OfType<RadioButton>()
                .Where(r => r.Checked)
                .Select(r => Convert.ToInt32(r.Tag))
                .Union(
                    flowLayoutPanelQuestions.Controls
                        .OfType<CheckBox>()
                        .Where(c => c.Checked)
                        .Select(c => Convert.ToInt32(c.Tag))
                ).ToList();

            if (selectedAnswers.Count == 0)
            {
                MessageBox.Show("Please select an answer before submitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the answer(s) to the Submit table
            foreach (int answerId in selectedAnswers)
            {
                UserService.SubmitAnswer(studentId, examId, questionId, answerId);
            }

            MessageBox.Show("Answer submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Move to the next question
            if (currentQuestionIndex < dtQuestions.Rows.Count - 1)
            {
                currentQuestionIndex++;
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("You have answered all questions.", "Exam Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}