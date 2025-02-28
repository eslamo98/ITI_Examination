using Examination_System.Business.Enums;
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
using Examination_System.Data_Access.Models;
using Examination_System.Presentation.Common;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminManageStudentUc : UserControl
    {
        public frmAdminManageStudentUc()
        {
            InitializeComponent();

            //initialize courses combobox

            DataTable coursesTable = CourseService.GetAllCourses();
            DataRow course = coursesTable.NewRow();
            course["Id"] = 0;
            course["CourseName"] = "All";
            coursesTable.Rows.InsertAt(course, 0);
            com_courses.DataSource = coursesTable;
            com_courses.DisplayMember = "CourseName";
            com_courses.ValueMember = "Id";

            com_courses.SelectedIndex = 0;


            //initialize teacher combobox
            DataTable teachersTable = UserService.GetAllTeachers();
            DataRow teacher = teachersTable.NewRow();
            teacher["Id"] = 0;
            teacher["TeacherName"] = "All";
            teachersTable.Rows.InsertAt(teacher, 0);
            com_teachers.DataSource = teachersTable;
            com_teachers.DisplayMember = "TeacherName";
            com_courses.ValueMember = "Id";

            com_courses.SelectedIndex = 0;

            //initialize dgv_students
            dgv_students.DataSource = UserService.GetAllStudents();
            CreateColumns();

        }

        private void CreateColumns()
        {

            if (!dgv_students.Columns.Contains("col_edit"))
            {
                EditDeleteButtonColumn();
            }
            if (!dgv_students.Columns.Contains("col_delete"))
            {
                AddDeleteButtonColumn();
            }
        }


        private void FilterStudents(object sender, EventArgs e)
        {
            if (com_teachers.SelectedItem is DataRowView teacherselectedRow && com_courses.SelectedItem is DataRowView courseselectedRow)
            {
                int teacherId = (int)teacherselectedRow["Id"];
                int courseId = (int)courseselectedRow["Id"];
                dgv_students.DataSource = UserService.FilterStudents(courseId, teacherId);


            }
        }
        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Delete";  // Column title
            btnColumn.Text = "delete";      // Button text
            btnColumn.Name = "col_delete";      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_students.Columns.Add(btnColumn); // Add to DataGridView
        }

        private void EditDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Edit";  // Column title
            btnColumn.Text = "edit";      // Button text
            btnColumn.Name = "col_edit";      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_students.Columns.Add(btnColumn); // Add to DataGridView
        }


        private void com_teachers_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterStudentAndLoadDgv();
        }

        private void filterStudentAndLoadDgv()
        {
            if (com_teachers.SelectedItem is DataRowView teacherselectedRow && com_courses.SelectedItem is DataRowView courseselectedRow)
            {
                int teacherId = (int)teacherselectedRow["Id"];
                int courseId = (int)courseselectedRow["Id"];

                dgv_students.DataSource = UserService.GetStudentsByTeacherAndCourse(courseId, teacherId);
                CreateColumns();
            }

        }

        private void HandleEDD_Buttons_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgv_students.Columns[e.ColumnIndex].Name == "col_delete")
                {
                    // delete button was clicked
                    int studentId = (int)dgv_students.Rows[e.RowIndex].Cells["Id"].Value;

                    if (MessageBox.Show($"Are you sure you want to delete this student>", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        int result = UserService.DeleteUserById(studentId);
                        switch (result)
                        {
                            case 1:
                                new ToastForm(ToastType.Info, "User was deleted successfully");
                                filterStudentAndLoadDgv();
                                break;
                            case 0:
                                new ToastForm(ToastType.Info, "You can't delete admin");

                                break;
                            case -1:
                                new ToastForm(ToastType.Error, "Error occured while deleting the user");

                                break;
                            default:
                                new ToastForm(ToastType.Error, "Unknown Error");

                                break;
                        }

                    }
                }
                else if (e.RowIndex >= 0 && dgv_students.Columns[e.ColumnIndex].Name == "col_edit")
                {
                    // edit button was clicked
                    int studentId = (int)dgv_students.Rows[e.RowIndex].Cells["Id"].Value;
                    User student = UserService.GetUsrById(studentId);
                    if (student.ID != 0)
                    {
                        General.LoadUserControl(new frmAdminCreateUserUc(student, OperationMode.Edit));
                    }
                }

            }
            catch (Exception ex)
            {

                new ToastForm(ToastType.Error, ex.Message).Show();
            }
        }

        private void btn_newstudent_Click(object sender, EventArgs e)
        {
            //new frmAdminCreateUser(ReturnForm.frmAdminManageStudents, UserRole.Student, OperationMode.Create).Show();
            General.LoadUserControl(new frmAdminCreateUserUc(UserRole.Student, OperationMode.Create));
        }

        private void btn_new_teacher_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminCreateUserUc(UserRole.Teacher, OperationMode.Create));

        }

        private void dgv_students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
