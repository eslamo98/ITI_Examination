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
using ExaminationSystem.Data_Access.Models;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminManageCoursesUc : UserControl
    {
        public frmAdminManageCoursesUc()
        {
            InitializeComponent();

            DataTable teachersTable = UserService.GetAllTeachers();
            DataRow teacher = teachersTable.NewRow();
            teacher["Id"] = 0;
            teacher["TeacherName"] = "All";
            teachersTable.Rows.InsertAt(teacher, 0);
            com_teachers.DataSource = teachersTable;
            com_teachers.DisplayMember = "TeacherName";


            com_teachers.SelectedIndex = 0;

            //initialize dgv_students
            dgv_courses.DataSource = CourseService.GetAllCoursesData();
            CreateColumns();

        }

        private void CreateColumns()
        {

            if (!dgv_courses.Columns.Contains("col_edit"))
            {
                EditDeleteButtonColumn();
            }
            if (!dgv_courses.Columns.Contains("col_delete"))
            {
                AddDeleteButtonColumn();
            }
        }


        private void handleFilter()
        {
            int teacherId = 0;
            if (com_teachers.SelectedItem is DataRowView teacherselectedRow)
            {
                teacherId = (int)teacherselectedRow["Id"];
            }
            //initialize dgv_students
            dgv_courses.DataSource = CourseService.GetAllCoursesData(teacherId, tx_coursename.Text.Trim());
        }
        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Delete";  // Column title
            btnColumn.Text = "delete";      // Button text
            btnColumn.Name = "col_delete";      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_courses.Columns.Add(btnColumn); // Add to DataGridView
        }

        private void EditDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Edit";  // Column title
            btnColumn.Text = "edit";      // Button text
            btnColumn.Name = "col_edit";      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_courses.Columns.Add(btnColumn); // Add to DataGridView
        }




        private void HandleEDD_Buttons_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgv_courses.Columns[e.ColumnIndex].Name == "col_delete")
                {
                    // delete button was clicked
                    int studentId = (int)dgv_courses.Rows[e.RowIndex].Cells["Id"].Value;

                    if (MessageBox.Show($"Are you sure you want to delete this student>", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        int result = UserService.DeleteUserById(studentId);
                        switch (result)
                        {
                            case 1:
                                new ToastForm(ToastType.Info, "User was deleted successfully");
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
                else if (e.RowIndex >= 0 && dgv_courses.Columns[e.ColumnIndex].Name == "col_edit")
                {
                    // edit button was clicked
                    int studentId = (int)dgv_courses.Rows[e.RowIndex].Cells["Id"].Value;
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
            General.LoadUserControl(new frmAdminCreateEditCourseUc(OperationMode.Create));
        }

        private void btn_new_teacher_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminCreateUserUc(UserRole.Teacher, OperationMode.Create));

        }

        private void com_teachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleFilter();
        }

        private void tx_coursename_TextChanged(object sender, EventArgs e)
        {
            handleFilter();
        }

        private void dgv_courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_courses.Columns[e.ColumnIndex].Name == "col_edit")
            {
                int courseId = (int)dgv_courses.Rows[e.RowIndex].Cells["ID"].Value;
                Course course = CourseService.GetCourseById(courseId);
                if(course != null)
                {
                    try {

                        General.LoadUserControl(new frmAdminCreateEditCourseUc(course, OperationMode.Edit));
                    }
                    catch(Exception ex)
                    {
                        new ToastForm(ToastType.Error, ex.Message).Show();
                    }
                } else
                {
                    new ToastForm(ToastType.Warning, "thee course was  not found!").Show();
                }
            } else if (e.RowIndex >= 0 && dgv_courses.Columns[e.ColumnIndex].Name == "col_delete"){

                //delete a course
                if(MessageBox.Show("Are you sure you want to delete this course?", "Warning",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int courseId = (int)dgv_courses.Rows[e.RowIndex].Cells["ID"].Value;
                    try
                    {
                        CreateEditCourseStatus result = CourseService.DeleteCourseById(courseId);
                        if (result == CreateEditCourseStatus.Success)
                        {
                            new ToastForm(ToastType.Success, "Course was deleted sussfully!").Show();
                            General.LoadUserControl(new frmAdminManageCoursesUc());
                        }
                        else
                        {
                            new ToastForm(ToastType.Error, "Course was not deleted!").Show();
                        }
                    }
                    catch (Exception ex)
                    {

                        new ToastForm(ToastType.Error, ex.Message).Show();
                    }
                }
            }
        }
    }
}

