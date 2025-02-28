using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Presentation.Common;
using ExaminationSystem.Data_Access.Models;
using System.Data;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminCreateEditCourseUc : UserControl
    {
        OperationMode _operation;
        Course _course;
        public frmAdminCreateEditCourseUc(OperationMode op)
        {
            InitializeComponent();
            _operation = op;
            LoadTeachers(UserService.GetAllTeachers);
        }
        public frmAdminCreateEditCourseUc(Course course, OperationMode op) : this(op)
        {
            _course = course;
            tx_coursename.Text = course.Name;
            n_courseduration.Value = course.Duration;
            n_coursegrade.Value = course.Grade;
            com_courseteacher.SelectedValue = course.TeacherID;
            lb_title.Text = $"Edit {course.Name} Course";
        }


        private void btn_back_Click_1(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminManageCoursesUc());
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Get values from input controls
            string courseName = tx_coursename.Text.Trim();
            int teacherId = (com_courseteacher.SelectedItem != null) ? Convert.ToInt32(com_courseteacher.SelectedValue) : -1;
            int courseGrade = (int)n_coursegrade.Value;
            int courseDuration = (int)n_courseduration.Value;

            // Validation checks using Utility methods
            if (Utility.IsNullOrEmpty(courseName))
            {
                new ToastForm(ToastType.Error,"Course name cannot be empty!").Show();
                return;
            }

            if (teacherId <= 0)
            {
                new ToastForm(ToastType.Error, "Please select a valid teacher!").Show();
                return;
            }

            if (!Utility.IsPositive(courseGrade))
            {
                new ToastForm(ToastType.Error, "Course grade must be a positive number!").Show();
                return;
            }

            if (!Utility.IsPositive(courseDuration))
            {
                new ToastForm(ToastType.Error, "Course duration must be a positive number!").Show();
                return;
            }

            // If all validations pass, proceed with inserting the course
            Course course = new Course() { Duration = courseDuration, Grade = courseGrade, Name = courseName, TeacherID = teacherId };
            try
            {
                CreateEditCourseStatus result = CreateEditCourseStatus.OtherError;
                if(_operation == OperationMode.Create)
                {
                    result = CourseService.CreateCourse(course);
                } else
                {
                    course.ID = _course.ID;
                    result = CourseService.UpdateCourse(course);
                }
                if(result == CreateEditCourseStatus.Success)
                {
                    new ToastForm(ToastType.Success, "Course saved successfully!").Show();
                    General.LoadUserControl(new frmAdminManageCoursesUc());
                } else if(result == CreateEditCourseStatus.UniqueConstraintViolation)
                {
                    new ToastForm(ToastType.Error, "Course name must be unique!").Show();

                }else if (result == CreateEditCourseStatus.NotNullViolation)
                {
                    new ToastForm(ToastType.Error, "Course name must not be empty or null!").Show();
                } else
                {
                    new ToastForm(ToastType.Error, "Unknown Error!").Show();
                }
            } catch(Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();
            }

        }

        private void LoadTeachers(Func<DataTable> fun)
        {
            com_courseteacher.DataSource = fun?.Invoke();
            com_courseteacher.DisplayMember = "TeacherName";
            com_courseteacher.ValueMember = "Id";

        }
    }
}
