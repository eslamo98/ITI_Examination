using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Presentation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminStudentExamsUc : UserControl
    {

        private int studentId;
        private int courseId;
        public frmAdminStudentExamsUc(int _studentId, int _courseId)
        {
            InitializeComponent();
            studentId = _studentId;
            courseId = _courseId;
            dgv_student_exams.DataSource = UserService.GetStudentExams(studentId, courseId);
            if (!dgv_student_exams.Columns.Contains("Show Exam"))
            {
                AddColumnButton("Show Exam");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminStudentCoursesUc(studentId));
        }

        private void AddColumnButton(string btnName)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = btnName;
            btn.Text = btnName;
            btn.Name = btnName;
            btn.UseColumnTextForButtonValue = true;
            dgv_student_exams.Columns.Add(btn);
        }

        private void Handle_Show_Exam(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgv_student_exams.Columns[e.ColumnIndex].Name == "Show Exam")
                {
                    int examId = (int)dgv_student_exams.Rows[e.RowIndex].Cells["ExamId"].Value;
                    //new frmShowStudentExam(studentId, examId).Show();
                    General.LoadUserControl(new frmShowStudentExamUc(studentId, examId));
                }
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();

            }
        }
    }
}
