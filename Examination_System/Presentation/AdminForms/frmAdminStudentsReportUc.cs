using Examination_System.Business;
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
    public partial class frmAdminStudentsReportUc : UserControl
    {
        public frmAdminStudentsReportUc()
        {
            InitializeComponent();
        }

        private void frmAdminStudentsReport_Load(object sender, EventArgs e)
        {

            // load courses in combo box
            var courses = CourseService.GetAllCourses();
            DataRow allCourse = courses.NewRow();
            allCourse["Id"] = 0;
            allCourse["CourseName"] = "All";
            courses.Rows.InsertAt(allCourse, 0);
            com_courses.DataSource = courses;
            com_courses.ValueMember = "Id";
            com_courses.DisplayMember = "CourseName";
            com_courses.SelectedIndex = 0;

            //load teachers in combo box
            var teachers = UserService.GetAllTeachers();
            DataRow allTeacher = teachers.NewRow();
            allTeacher["Id"] = 0;
            allTeacher["TeacherName"] = "All";
            teachers.Rows.InsertAt(allTeacher, 0);
            com_teachers.DataSource = teachers;
            com_teachers.ValueMember = "Id";
            com_teachers.DisplayMember = "TeacherName";
            com_teachers.SelectedIndex = 0;

            filterStudentAndLoadDgv(0, 0);

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminReportsUc());
        }

        private void filterStudentAndLoadDgv(int courseId, int teacherId)
        {
            dgv_students.DataSource = UserService.GetStudentsByTeacherAndCourse(courseId, teacherId);
            if (!dgv_students.Columns.Contains("View Courses"))
            {
                AddColumnBtn("View Courses");
            }
        }

        private void AddColumnBtn(string btnName)
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = btnName;  // Column title
            btnColumn.Text = btnName;      // Button text
            btnColumn.Name = btnName;      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_students.Columns.Add(btnColumn); // Add to DataGridView
        }

        private void FiltersChanged(object sender, EventArgs e)
        {
            try
            {
                if (com_teachers.SelectedItem is DataRowView teacherselectedRow && com_courses.SelectedItem is DataRowView courseselectedRow)
                {
                    int teacherId = (int)teacherselectedRow["Id"];
                    int courseId = (int)courseselectedRow["Id"];
                    filterStudentAndLoadDgv(courseId, teacherId);
                }

            }
            catch (Exception ex)
            {
                new ToastForm(Business.Enums.ToastType.Error, ex.Message).Show();
            }
        }

        private void Handle_View_Courses(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0 && dgv_students.Columns[e.ColumnIndex].Name == "View Courses")
                {
                    // View Courses button was clicked
                    int studentId = (int)dgv_students.Rows[e.RowIndex].Cells["Id"].Value;
                    General.LoadUserControl(new frmAdminStudentCoursesUc(studentId));
                }
            }
            catch (Exception ex)
            {
                new ToastForm(Business.Enums.ToastType.Error, ex.Message).Show();

            }
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminReportsUc());
        }
    }
}
