using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Data_Access.Models;
using Examination_System.Presentation;
using Examination_System.Presentation.Common;

namespace Examination_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentProfile s = new frmStudentProfile(this);
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmAdminProfile a = new frmAdminProfile();
            //a.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_click(object sender, EventArgs e)
        {
            try
            {
                Tuple<int, User> result = UserService.Login(tx_username.Text.Trim(), tx_pass.Text.Trim());
                switch (result.Item1)
                {
                    case 0:
                        new ToastForm(ToastType.Success, "Login successful.").Show();
                        break;
                    case 1:
                        new ToastForm(ToastType.Error, "Invalid username or email.").Show();
                        break;
                    case 2:
                        new ToastForm(ToastType.Error, "Incorrect password.").Show();
                        break; 
                    default:
                        new ToastForm(ToastType.Error, "Unknown error.").Show();
                        break;
                }
                
                General.LoggedUser = result.Item2;
                if (result.Item2.Username != null && result.Item2.ID != 0)
                {
                    this.Hide();
                    tx_pass.Text = string.Empty;
                    tx_username.Text = string.Empty;
                    if (result.Item2.UserRole == UserRole.Admin)
                    {

                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.Show();
                    }
                    else if (result.Item2.UserRole == UserRole.Teacher)
                    {
                        frmTeacher frmTeacher = new frmTeacher();
                        frmTeacher.Show();
                    }
                    else if (result.Item2.UserRole == UserRole.Student)
                    {
                        frmStudentProfile frmStudentProfile = new frmStudentProfile();
                        frmStudentProfile.Show();
                    }
                }
                else
                {
                    tx_pass.Text = string.Empty;
                    tx_username.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();
                throw;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
