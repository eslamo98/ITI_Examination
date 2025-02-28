using Examination_System.Business.Enums;
using Examination_System.Business.StudentExamService;
using Examination_System.Presentation.Common;
using Examination_System.Presentation.StudentForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Examination_System.Presentation
{
    public partial class frmStudentExam : Form
    {
        private int stdID;
        private StudentNextExamService _examService;

        public frmStudentExam()
        {
            InitializeComponent();
            stdID = General.LoggedUser?.ID ?? 0; // تجنب الخطأ في حالة عدم تسجيل الدخول
            _examService = new StudentNextExamService();
        }

        public frmStudentExam(int studentID)
        {
            InitializeComponent();
            this.stdID = studentID;
            _examService = new StudentNextExamService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStudentProfile frmStudentProfile = new frmStudentProfile();
            frmStudentProfile.Show();
        }

        private void frmStudentExam_Load(object sender, EventArgs e)
        {
            LoadStudentExams();
        }

        private void LoadStudentExams()
        {
            try
            {
                DataTable dt = _examService.GetStudentNextExams(stdID);
                dgvStudentExams.DataSource = dt;
                AddShowExamColumn();
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();
            }
        }

        private void AddShowExamColumn()
        {
            if (dgvStudentExams.Columns["Col_ExamAction"] == null)
            {
                DataGridViewButtonColumn showExamColumn = new DataGridViewButtonColumn
                {
                    Name = "Col_ExamAction",
                    HeaderText = "Exam Action",
                    Text = "Open Exam",
                    UseColumnTextForButtonValue = true
                };
                dgvStudentExams.Columns.Add(showExamColumn);
            }
        }

        private void dgvStudentExams_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvStudentExams.Columns[e.ColumnIndex].Name != "Col_ExamAction")
                return;

            var cellValue = dgvStudentExams.Rows[e.RowIndex].Cells["StartTime"].Value;
            if (cellValue != null && cellValue != DBNull.Value)
            {
                DateTime examDate = Convert.ToDateTime(cellValue);
                DateTime examEndTime = examDate.AddHours(1);

                if (DateTime.Now < examDate)
                {
                    e.Value = "Pending";
                    dgvStudentExams.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Gray;
                }
                else if (DateTime.Now >= examDate && DateTime.Now <= examEndTime)
                {
                    e.Value = "Open Exam";
                    dgvStudentExams.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                }
                else if (DateTime.Now > examEndTime)
                {
                    e.Value = "Finished";
                    dgvStudentExams.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Gray;
                }
            }
        }

        private void dgvStudentExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row and the "Col_ExamAction" column
            if (e.RowIndex < 0 || dgvStudentExams.Columns[e.ColumnIndex]?.Name != "Col_ExamAction")
                return;

            // Get the value of the "Col_ExamAction" cell in the clicked row
            string actionText = dgvStudentExams.Rows[e.RowIndex].Cells["Col_ExamAction"]?.Value?.ToString();

            // Check if the action is "Open Exam"
            if (actionText == "Open Exam")
            {
                // Ensure the "Id" column exists and has a value
                if (dgvStudentExams.Rows[e.RowIndex].Cells["Id"]?.Value == null)
                {
                    MessageBox.Show("Exam ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Retrieve the Exam ID from the "Id" column
                int examID = Convert.ToInt32(dgvStudentExams.Rows[e.RowIndex].Cells["Id"]?.Value);

                // Open the exam form with the retrieved Exam ID and the student ID (stdID)
                frmShowStudentExam examForm = new frmShowStudentExam(stdID, examID);
                examForm.ShowDialog();
            }
            else
            {
                // If the action is not "Open Exam", show a message
                MessageBox.Show("The exam is not available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}