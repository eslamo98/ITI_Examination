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
    public partial class frmAdminStudentCoursesUc : UserControl
    {

        private readonly int studentId;

        public frmAdminStudentCoursesUc(int id)
        {
            InitializeComponent();
            studentId = id;
            dgv_student_courses.DataSource = UserService.GetStudentCourses(id);
            if (!dgv_student_courses.Columns.Contains("View Exams"))
            {
                AddColumnButton("View Exams");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminStudentsReportUc());
        }

        private void AddColumnButton(string btnName)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = btnName;
            btn.Text = btnName;
            btn.Name = btnName;
            btn.UseColumnTextForButtonValue = true;
            dgv_student_courses.Columns.Add(btn);
        }

        private void HandleShowExams(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgv_student_courses.Columns[e.ColumnIndex].Name == "View Exams")
                {
                    int courseId = (int)dgv_student_courses.Rows[e.RowIndex].Cells["Id"].Value;
                    General.LoadUserControl(new frmAdminStudentExamsUc(studentId, courseId));
                }
            }
            catch (Exception ex)
            {

                new ToastForm(ToastType.Error, ex.Message);
            }
        }
    }
}
