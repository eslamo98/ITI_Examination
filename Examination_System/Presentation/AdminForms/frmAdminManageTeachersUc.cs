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
using Examination_System.Presentation.Common;
using Examination_System.Data_Access.Models;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminManageTeachersUc : UserControl
    {
        DataTable dt = AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
        //BindingSource binding_source;
        //BindingNavigator binding_navigator;






        public frmAdminManageTeachersUc()
        {
            InitializeComponent();

        }

      

        private void frmAdminManageTeachers_Load(object sender, EventArgs e)
        {


            dgv_Teacher.DataSource = dt;
            //Controls.Add(binding_navigator);
            //binding_navigator.Dock = DockStyle.Bottom;
            LoadComboBoxData();
            CreateColumns();

        }

        private void CreateColumns()
        {

            if (!dgv_Teacher.Columns.Contains("col_edit"))
            {
                EditDeleteButtonColumn();
            }
            if (!dgv_Teacher.Columns.Contains("col_delete"))
            {
                AddDeleteButtonColumn();
            }

        }
        private void pnl_nav_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Teacher_Info_Report(object sender, DataGridViewCellEventArgs e)
        {
            new Teacher_Info_Report().Show();
        }

        private void dgv_Teacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void HandleEDD_Buttons_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgv_Teacher.Columns[e.ColumnIndex].Name == "col_edit")
                {
                    // edit button was clicked
                    int teacherId = (int)dgv_Teacher.Rows[e.RowIndex].Cells["Id"].Value;
                    User teacher = UserService.GetUsrById(teacherId);
                    if (teacher.ID != 0)
                    {
                        General.LoadUserControl(new frmAdminCreateUserUc(teacher, OperationMode.Edit, ReturnForm.frmAdminManageTeachersUc));
                    }
                } else if (e.RowIndex >= 0 && dgv_Teacher.Columns[e.ColumnIndex].Name == "col_delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this teacher?", "Warning",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        // edit button was clicked
                        int teacherId = (int)dgv_Teacher.Rows[e.RowIndex].Cells["Id"].Value;
                        if (teacherId != 0)
                        {
                            int result = UserService.DeleteTeacherById(teacherId);
                            if (result == 1)
                            {
                                new ToastForm(ToastType.Success, "Teacher was deleted successfully!").Show();
                                General.LoadUserControl(new frmAdminManageTeachersUc());
                            }
                            else if (result == 0)
                            {
                                new ToastForm(ToastType.Warning, "Teacher was not deleted!").Show();
                            }
                            else if (result == -1)
                            {
                                new ToastForm(ToastType.Info, "Teacher was not found!").Show();
                            }
                            else
                            {
                                new ToastForm(ToastType.Error, "Unknown!").Show();

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                new ToastForm(ToastType.Error, ex.Message).Show();
            }
        }

        private void lbl_Search_Id_Click(object sender, EventArgs e)
        {

        }

        private void SearchById(object sender, KeyEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txb_search_Id.Text))
            {
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                return;
            }
            string _id = txb_search_Id.Text.Trim();
            int id;
            if (int.TryParse(_id, out id))
            {
                dgv_Teacher.DataSource = AdminManageTeacherService.Search_ById(id);
            }
            else
            {
                MessageBox.Show("No Recored is Found.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
            }
        }
        private void EditDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Edit";  // Column title
            btnColumn.Text = "edit";      // Button text
            btnColumn.Name = "col_edit";      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_Teacher.Columns.Add(btnColumn); // Add to DataGridView
        }
        private void SearchByName(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_SearchByName.Text))
            {
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                return;
            }
            try
            {

                string name = txb_SearchByName.Text.Trim();
                dgv_Teacher.DataSource = AdminManageTeacherService.Search_ByName(name);
            }
            catch
            {
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                MessageBox.Show("No Recored is Found.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void txb_SearchByName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                MessageBox.Show("Please enter a valid Name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txb_search_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //DataTable dt = Business.AdminManageTeacherService.AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
            }
        }
        private void LoadComboBoxData()
        {
            try
            {

                DataTable dt;
                dt = AdminManageTeacherService.GetAll_Courses();
                DataRow allCoursesRow = dt.NewRow();
                allCoursesRow["CourseName"] = "All Courses";
                allCoursesRow["ID"] = 0;
                dt.Rows.InsertAt(allCoursesRow, 0);
                cmb_Cources.DataSource = dt;
                cmb_Cources.DisplayMember = "CourseName";
                cmb_Cources.ValueMember = "ID";
                cmb_Cources.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Delete";  // Column title
            btnColumn.Text = "delete";      // Button text
            btnColumn.Name = "col_delete";      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_Teacher.Columns.Add(btnColumn); // Add to DataGridView
        }
        private void FilterByCources(int id)
        {

            try
            {

                DataTable dt = AdminManageTeacherService.Search_ByCourse(id);
                dgv_Teacher.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void cmb_Cources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Cources.SelectedValue == null || cmb_Cources.SelectedIndex == 0)
            {
                DataTable dt = AdminManageTeacherService.GetAllTeachers((int)UserRole.Teacher);
                dgv_Teacher.DataSource = dt;
                return;
            }
            int selectedCategory;
            if (int.TryParse(cmb_Cources.SelectedValue.ToString(), out selectedCategory))
            {
                FilterByCources(selectedCategory);
                txb_SearchByName.Clear();
                txb_search_Id.Clear();
                return;
            }
            else
            {
                return;
            }

        }

        private void txb_SearchByName_TextChanged(object sender, EventArgs e)
        {
            txb_search_Id.Clear();
            cmb_Cources.SelectedIndex = 0;
        }

        private void txb_search_Id_TextChanged(object sender, EventArgs e)
        {
            txb_SearchByName.Clear();
            cmb_Cources.SelectedIndex = 0;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            AdminManageTeacherService.ExportToExcel(dgv_Teacher);
        }

        private void btn_new_teacher_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminCreateUserUc(UserRole.Teacher, OperationMode.Create, ReturnForm.frmAdminManageTeachersUc));

        }
    }
}
