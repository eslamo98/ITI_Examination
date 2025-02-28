using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Examination_System.Presentation.StudentForms
{
    public partial class frmExam : Form
    {
        private int studentID;
        private int examID;
        private int timeRemaining = 900; // 15 دقيقة
        private Dictionary<int, TextBox> studentAnswers = new Dictionary<int, TextBox>();
        private Timer timerExam; // تعريف المؤقت

        public frmExam(int examID, int studentID)
        {
            InitializeComponent();
            this.examID = examID;
            this.studentID = studentID;
            InitializeTimer(); // تهيئة المؤقت
        }

        private void frmExam_Load(object sender, EventArgs e)
        {
            LoadQuestions();
            StartExamTimer();
        }

        private void InitializeTimer()
        {
            timerExam = new Timer();
            timerExam.Interval = 1000;
            timerExam.Tick += TimerExam_Tick;
        }

        private void LoadQuestions()
        {
            panelQuestions.Controls.Clear();
            string connectionString = "your_connection_string_here";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT q.QuestionID, q.QuestionText 
                    FROM ExamQuestion eq
                    JOIN Questions q ON eq.QuestionID = q.QuestionID
                    WHERE eq.ExamID = @ExamID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExamID", examID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int yOffset = 10;
                    while (reader.Read())
                    {
                        int questionID = reader.GetInt32(0);
                        string questionText = reader.GetString(1);

                        Label lblQuestion = new Label
                        {
                            Text = questionText,
                            Location = new Point(10, yOffset),
                            Size = new Size(800, 30)
                        };
                        panelQuestions.Controls.Add(lblQuestion);

                        TextBox txtAnswer = new TextBox
                        {
                            Name = $"txtAnswer_{questionID}",
                            Location = new Point(10, yOffset + 35),
                            Size = new Size(500, 30)
                        };
                        panelQuestions.Controls.Add(txtAnswer);
                        studentAnswers[questionID] = txtAnswer;

                        yOffset += 80;
                    }
                }
            }
        }

        private void StartExamTimer()
        {
            timerExam.Start();
        }

        private void TimerExam_Tick(object sender, EventArgs e)
        {
            timeRemaining--;
            lblTime.Text = $"Time Left: {timeRemaining / 60}:{timeRemaining % 60}";

            if (timeRemaining <= 0)
            {
                timerExam.Stop();
                MessageBox.Show("Time is up! Submitting exam automatically.", "Time Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SubmitExam();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SubmitExam();
            }
        }

        private void SubmitExam()
        {
            string connectionString = "your_connection_string_here";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var entry in studentAnswers)
                {
                    int questionID = entry.Key;
                    string answerText = entry.Value.Text;

                    string insertQuery = @"
                        INSERT INTO Submit (StudentID, ExamID, QuestionID, AnswerText)
                        VALUES (@StudentID, @ExamID, @QuestionID, @AnswerText)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@ExamID", examID);
                        cmd.Parameters.AddWithValue("@QuestionID", questionID);
                        cmd.Parameters.AddWithValue("@AnswerText", answerText);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Exam submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}