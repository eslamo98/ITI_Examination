using Examination_System.Business;
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
    public partial class frmAdminStudentCoursesReport : Form
    {

        private readonly int studentId;

        public frmAdminStudentCoursesReport(int id)
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
            this.Close();
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
                if(e.RowIndex >=0 && dgv_student_courses.Columns[e.ColumnIndex].Name == "View Exams")
                {
                    int courseId = (int)dgv_student_courses.Rows[e.RowIndex].Cells["Id"].Value;
                    //new frmAdminStudentExams(studentId, courseId).Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
