using Examination_System.Business.Enums;
using Examination_System.Business;
using ExaminationSystem.Data_Access.Models;
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

    public partial class frmAdminCreateUserUc : UserControl
    {
        private readonly UserRole role;
        private readonly User _user = new User();
        private readonly OperationMode operationMode;
        private readonly ReturnForm _returnForm;

        public frmAdminCreateUserUc()
        {
            InitializeComponent();
            
            com_gender.DataSource = Enum.GetValues(typeof(Gender));
        }

        //edit student or teacher
        public frmAdminCreateUserUc(User user, OperationMode _operationMode, ReturnForm returnForm = ReturnForm.frmAdminManageStudentsUc) : this()
        {
            _returnForm = returnForm;
            this._user = user;
            this.role = user.UserRole;
            UserService.SetUserImage(pic_userImg, user);
            tx_username.Text = user.Username;
            tx_email.Text = user.Email;
            tx_firstname.Text = user.FirstName;
            tx_lastname.Text = user.LastName;
            tx_password.Text = user.PasswordHash;
            tx_ssn.Text = user.SSN;
            tx_username.Text = user.Username;

            if(role == UserRole.Student)
            {
                lb_title.Text = $"Edit Student: {user.Fullname}";

                LoadCourses(CourseService.GetAllCourses);
                
            } else if(role == UserRole.Teacher)
            {
                lb_title.Text = $"Edit Teacher: {user.Fullname}";
                LoadCourses(UserService.getAllCoursesForTeacher,user.ID);
                
            }
            operationMode = _operationMode;

            com_gender.SelectedItem = user.Gender;
            try
            {
                if(role == UserRole.Student)
                {
                    List<Course> studentCourses = new List<Course>();
                    var stdCourses = UserService.GetAllCoursesStudentEnrolledIn(user.ID);
                    foreach (DataRow item in stdCourses.Rows)
                    {
                        studentCourses.Add(new Course()
                        {
                            ID = Convert.ToInt32(item["Id"]), // Assuming Id is an integer
                            Name = item["CourseName"].ToString() // Assuming CourseName is a string
                        });
                    }

                    for (int i = 0; i < clb_courses.Items.Count; i++)
                    {
                        var rowView = clb_courses.Items[i] as DataRowView;
                        Course course = new Course() { ID = Convert.ToInt32(rowView.Row["Id"]), Name = rowView.Row["CourseName"].ToString() };
                        if (course != null && studentCourses.Any(sc => sc.ID == course.ID))
                        {
                            clb_courses.SetItemChecked(i, true); // Check the item
                        }
                    }
                } else if(role == UserRole.Teacher)
                {
                    List<Course> studentCourses = new List<Course>();
                    var stdCourses = UserService.GetTeacherCourses(user.ID);
                    foreach (DataRow item in stdCourses?.Rows)
                    {
                        studentCourses.Add(new Course()
                        {
                            ID = Convert.ToInt32(item["Id"]), // Assuming Id is an integer
                            Name = item["CourseName"].ToString() // Assuming CourseName is a string
                        });
                    }

                    for (int i = 0; i < clb_courses.Items.Count; i++)
                    {
                        var rowView = clb_courses.Items[i] as DataRowView;
                        Course course = new Course() { ID = Convert.ToInt32(rowView.Row["Id"]), Name = rowView.Row["CourseName"].ToString() };
                        if (course != null && studentCourses.Any(sc => sc.ID == course.ID))
                        {
                            clb_courses.SetItemChecked(i, true); // Check the item
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                new ToastForm(ToastType.Error,ex.Message);
            }
        }


        //create student or teacher
        public frmAdminCreateUserUc( UserRole _role, OperationMode _operationMode, ReturnForm returnForm = ReturnForm.frmAdminManageStudentsUc) : this()
        {
            _returnForm = returnForm;
            role = _role;
            operationMode = _operationMode;

            if(role == UserRole.Student)
            {
                lb_title.Text = "Create new Student";
                LoadCourses(CourseService.GetAllCourses);
            }
            else
            {
                lb_title.Text = "Create new Teacher";
                LoadCourses(UserService.GetAllAvialableCourses);
            }
        }

        

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                // the form handle create and update the students data
                if (role == UserRole.Student)
                {
                    // the form is used to create new student
                    if (operationMode == OperationMode.Create)
                    {
                        CreateStudent();
                    }
                    //the form is used to edit the student data
                    else if (operationMode == OperationMode.Edit)
                    {
                        UpdateStudent();
                    }

                }

                // the form handle create and update the teacher data
                else if (role == UserRole.Teacher)
                {
                    // the form is used to create new Teacher
                    if (operationMode == OperationMode.Create)
                    {
                        CreateTeacher();
                    }
                    //the form is used to edit the teacher data
                    else if (operationMode == OperationMode.Edit)
                    {
                        UpdateTeacher();
                    }
                }
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error,ex.Message).Show();

            }
        }


        private void CreateStudent()
        {
            User user = new User()
            {
                Email = tx_email.Text.Trim(),
                FirstName = tx_firstname.Text.Trim(),
                Gender = (Gender)com_gender.SelectedItem,
                LastName = tx_lastname.Text.Trim(),
                PasswordHash = tx_password.Text.Trim(),
                SSN = tx_ssn.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = UserRole.Student,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                user.UserImg = stream.GetBuffer();
            }
            List<int> selectedCourses = new();
            foreach (var item in clb_courses.CheckedItems)
            {
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null)
                {
                    selectedCourses.Add((int)dataRowView["Id"]);
                }
            }
            int result = UserService.CreateUpdateUser(user, selectedCourses, OperationMode.Create);
            if (result == ((int)UserErrorMessage.Suceeded))
            {
                new ToastForm(ToastType.Success,"Student was created successfully").Show();
                
                    General.LoadUserControl(new frmAdminManageStudentUc());
            }
            else
            {
                if(result == ((int)UserErrorMessage.NotUniqueUsername))
                    new ToastForm(ToastType.Error,"This username already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueEmail))
                    new ToastForm(ToastType.Error,"This email already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueSSN))
                    new ToastForm(ToastType.Error, "This SSN already exist").Show();
                else 
                    new ToastForm(ToastType.Error, "Unknown Error").Show();

            }
        }

        private void UpdateStudent()
        {
            User updatedUser = new User()
            {
                ID = _user.ID,
                Email = tx_email.Text.Trim(),
                FirstName = tx_firstname.Text.Trim(),
                Gender = (Gender)com_gender.SelectedItem,
                LastName = tx_lastname.Text.Trim(),
                PasswordHash = tx_password.Text.Trim(),
                SSN = tx_ssn.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = UserRole.Student,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                updatedUser.UserImg = stream.GetBuffer();
            }
            List<int> selectedCourses = new();
            foreach (var item in clb_courses.CheckedItems)
            {
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null)
                {
                    selectedCourses.Add((int)dataRowView["Id"]);
                }
            }
            int result = UserService.CreateUpdateUser(updatedUser, selectedCourses, OperationMode.Edit);
            if (result == 1)
            {
                new ToastForm(ToastType.Success, "Student was updated successfully").Show();
                
                    General.LoadUserControl(new frmAdminManageStudentUc());
                
            }
            else
            {

                if (result == ((int)UserErrorMessage.NotUniqueUsername))
                    new ToastForm(ToastType.Error, "This username already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueEmail))
                    new ToastForm(ToastType.Error, "This email already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueSSN))
                    new ToastForm(ToastType.Error, "This SSN already exist").Show();
                else
                    new ToastForm(ToastType.Error, "Unknown Error").Show();
            }
        }

        private void CreateTeacher()
        {
            
            
            User user = new User()
            {
                Email = tx_email.Text.Trim(),
                FirstName = tx_firstname.Text.Trim(),
                Gender = (Gender)com_gender.SelectedItem,
                LastName = tx_lastname.Text.Trim(),
                PasswordHash = tx_password.Text.Trim(),
                SSN = tx_ssn.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = UserRole.Teacher,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                user.UserImg = stream.GetBuffer();
            }
            List<int> selectedCourses = new();
            foreach (var item in clb_courses.CheckedItems)
            {
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null)
                {
                    selectedCourses.Add((int)dataRowView["Id"]);
                }
            }
            int result = UserService.CreateUpdateUser(user, selectedCourses, OperationMode.Create);
            if (result == ((int)UserErrorMessage.Suceeded))
            {
                new ToastForm(ToastType.Success, "Teacher was created successfully").Show();
                
                    //new frmAdminManageStudents().Show();
                    General.LoadUserControl(new frmAdminManageTeachersUc());
            }
            else
            {
                if (result == ((int)UserErrorMessage.NotUniqueUsername))
                    new ToastForm(ToastType.Error, "This username already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueEmail))
                    new ToastForm(ToastType.Error, "This email already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueSSN))
                    new ToastForm(ToastType.Error, "This SSN already exist").Show();
                else
                    new ToastForm(ToastType.Error, "Unknown Error").Show();

            }
        }

        private void UpdateTeacher()
        {


            User user = new User()
            {
                ID = _user.ID,
                Email = tx_email.Text.Trim(),
                FirstName = tx_firstname.Text.Trim(),
                Gender = (Gender)com_gender.SelectedItem,
                LastName = tx_lastname.Text.Trim(),
                PasswordHash = tx_password.Text.Trim(),
                SSN = tx_ssn.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = UserRole.Teacher,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                user.UserImg = stream.GetBuffer();
            }
            List<int> selectedCourses = new();
            foreach (var item in clb_courses.CheckedItems)
            {
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null)
                {
                    selectedCourses.Add((int)dataRowView["Id"]);
                }
            }
            int result = UserService.CreateUpdateUser(user, selectedCourses, OperationMode.Edit);
            if (result == ((int)UserErrorMessage.Suceeded))
            {
                new ToastForm(ToastType.Success, "Teacher was Updated successfully").Show();

                //new frmAdminManageStudents().Show();
                General.LoadUserControl(new frmAdminManageTeachersUc());
            }
            else
            {
                if (result == ((int)UserErrorMessage.NotUniqueUsername))
                    new ToastForm(ToastType.Error, "This username already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueEmail))
                    new ToastForm(ToastType.Error, "This email already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueSSN))
                    new ToastForm(ToastType.Error, "This SSN already exist").Show();
                else
                    new ToastForm(ToastType.Error, "Unknown Error").Show();

            }
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = ".png|*.png|.jpg|*.jpg|.jpeg|*.jpeg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_userImg.Image = new Bitmap(fileDialog.FileName);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            if(_returnForm == ReturnForm.frmAdminManageStudentsUc)
            {
                General.LoadUserControl(new frmAdminManageStudentUc());
            } else
            {
                General.LoadUserControl(new frmAdminManageTeachersUc());
            }
        }

        private void LoadCourses(Func<DataTable> action)
        {
            clb_courses.DataSource = action?.Invoke();
            clb_courses.ValueMember = "Id";
            clb_courses.DisplayMember = "CourseName";
        }
        private void LoadCourses(Func< int,  DataTable> action, int x)
        {
            clb_courses.DataSource = action?.Invoke(x);
            clb_courses.ValueMember = "Id";
            clb_courses.DisplayMember = "CourseName";
        }
    }
}
