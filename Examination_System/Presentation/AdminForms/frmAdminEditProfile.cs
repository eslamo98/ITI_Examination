using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation
{
    public partial class frmAdminEditProfile : Form
    {
        private readonly User user = new User();
        private readonly ReturnForm returnForm;
        public frmAdminEditProfile(User _user, ReturnForm _returnForm)
        {
            InitializeComponent();
            user = _user;
            returnForm = _returnForm;
            UserService.SetUserImage(pic_userImg, user);
            tx_username.Text = user.Username;
            tx_email.Text = user.Email;
            tx_firstname.Text = user.FirstName;
            tx_lastname.Text = user.LastName;
            tx_password.Text = user.PasswordHash;
            tx_ssn.Text = user.SSN;
            tx_username.Text = user.Username;
            

            com_gender.DataSource = Enum.GetValues(typeof(Gender));

            
            com_gender.SelectedItem = user.Gender;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            User updatedUser = new User()
            {
                ID = user.ID,
                PasswordHash = tx_password.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = user.ID == General.LoggedUser.ID? UserRole.Admin: user.UserRole,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                updatedUser.UserImg = stream.GetBuffer();
            }
            //not fount
            Tuple<string, int> result = new Tuple<string, int>("User not found", -1);
            try
            {
                result = UserService.UpdateUserData(updatedUser);
                if (result.Item2 == ((int)UserErrorMessage.Suceeded))
                {
                    if(user.ID == General.LoggedUser.ID)
                    {
                        General.LoggedUser = updatedUser;
                    }
                    MessageBox.Show(result.Item1, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    if (returnForm == ReturnForm.frmAdminProfile)
                    {
                        new frmAdminProfile().Show();
                    }
                    else if (returnForm == ReturnForm.frmAdminManageStudents)
                    {
                        new frmAdminManageStudents().Show();
                    }
                }
                else
                {
                    MessageBox.Show(result.Item1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    //if(returnForm == ReturnForm.frmAdminProfile)
                    //{
                    //    new frmAdminProfile().Show();
                    //} else if(returnForm == ReturnForm.frmAdminManageStudents)
                    //{
                    //    new frmAdminManageStudents().Show();
                    //}
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void browse_btn_click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = ".png|*.png|.jpg|*.jpg|.jpeg|*.jpeg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                pic_userImg.Image = new Bitmap(fileDialog.FileName);
            }
        }
    }
}
