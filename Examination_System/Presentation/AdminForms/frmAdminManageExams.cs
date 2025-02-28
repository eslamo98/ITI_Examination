using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_System.Business;
using Examination_System.Business.AdminManageExamService;
using Examination_System.Business.Enums;
using Examination_System.Data_Access;
using Examination_System.Presentation.Common;
using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminManageExams : Form
    {
        DataTable dt = AdminManageExamService.GetAllExams();
        ToastForm toastForm;

        public frmAdminManageExams()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminDashboard().Show();
        }
        //-------edit exam -----
        private void dgv_Exam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            #region old Version
            //if (dgv_Exam.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            //{
            //    if (int.TryParse(dgv_Exam.Rows[e.RowIndex].Cells["ID"].Value?.ToString(), out int examId))
            //    {
            //        // MessageBox.Show($"Exam ID: {examId}"); // Debugging line
            //        Exam exam = AdminEditExamService.GetExamById(examId);
            //        if (exam.StartTime <= DateTime.Now)
            //        {
            //            //MessageBox.Show("Cannot be Update Old Exams.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            toastForm = new ToastForm(ToastType.Error, "Cannot be Update Old Exams.");
            //            toastForm.Show();
            //            return;
            //        }
            //        if (exam != null)
            //        {
            //            frmAdminEditExam frmEdit = new frmAdminEditExam(exam);
            //            frmEdit.EditExam(examId);
            //            frmEdit.ShowDialog();
            //            frmAdminEditExam.LoadExamDetails();

            //        }
            //        else
            //        {
            //            MessageBox.Show("Exam not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Exam ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    if (dgv_Exam.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            //    {
            //        if (int.TryParse(dgv_Exam.Rows[e.RowIndex].Cells["ID"].Value?.ToString(), out int exam_Id))
            //        {                      
            //            Exam exam = AdminEditExamService.GetExamById(examId);
            //            DateTime examEndTime = exam.EndTime;
            //            if (examEndTime < DateTime.Now)
            //            {
            //                toastForm = new ToastForm(ToastType.Error, "You cannot delete an exam that has already ended.");
            //                return;
            //            }
            //            DialogResult result = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //            if (result == DialogResult.Yes)
            //            {
            //                if (AdminEditExamService.DeleteExam(exam_Id) > 0)
            //                {
            //                    MessageBox.Show("Exam deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    frmAdminEditExam.LoadExamDetails();
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Failed to delete exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //            }
            //        }
            //    }
            //} 
            #endregion


            if (e.RowIndex < 0)
                return;


            string columnName = dgv_Exam.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit")
            {

                if (int.TryParse(dgv_Exam.Rows[e.RowIndex].Cells["ID"].Value?.ToString(), out int examId))
                {
                    Exam exam = AdminEditExamService.GetExamById(examId);
                    if (exam == null)
                    {
                        MessageBox.Show("Exam not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (exam.StartTime <= DateTime.Now)
                    {
                        toastForm = new ToastForm(ToastType.Error, "Cannot update old exams.");
                        toastForm.Show();
                        return;
                    }

                    frmAdminEditExam frmEdit = new frmAdminEditExam(exam);
                    frmEdit.EditExam(examId);
                    frmEdit.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid Exam ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (columnName == "Delete")
            {

                if (int.TryParse(dgv_Exam.Rows[e.RowIndex].Cells["ID"].Value?.ToString(), out int exam_Id))
                {
                    Exam exam = AdminEditExamService.GetExamById(exam_Id);
                    if (exam == null)
                    {
                        MessageBox.Show("Exam not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (exam.EndTime < DateTime.Now)
                    {
                        toastForm = new ToastForm(ToastType.Error, "You cannot delete an exam that has already ended.");
                        toastForm.Show();
                        return;
                    }

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (AdminEditExamService.DeleteExam(exam_Id) > 0)
                        {
                            toastForm = new ToastForm(ToastType.Success, "Exam deleted successfully.");
                            toastForm.Show();
                             MessageBox.Show("Exam deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Failed to delete exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Exam ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void frmAdminManageExams_Load(object sender, EventArgs e)
        {

            dgv_Exam.DataSource = dt;
            dgv_Exam.Refresh();
            LoadComboBoxData();
            AddUpdateButtonColumn();
        }

        private void AddUpdateButtonColumn()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "Action";
            editButton.Text = "Edit";
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Action";
            deleteButton.Text = "Delete";
            editButton.UseColumnTextForButtonValue = true;
            dgv_Exam.Columns.Add(editButton);
            deleteButton.UseColumnTextForButtonValue = true;
            dgv_Exam.Columns.Add(deleteButton);
        }


        private void LoadComboBoxData()
        {
            try
            {

                DataTable dt;
                dt = AdminManageExamService.GetAll_Courses();
                DataRow allCoursesRow = dt.NewRow();
                allCoursesRow["CourseName"] = "All Courses";
                allCoursesRow["ID"] = 0;
                dt.Rows.InsertAt(allCoursesRow, 0);
                cmb_SearchByCourse.DataSource = dt;
                cmb_SearchByCourse.DisplayMember = "CourseName";
                cmb_SearchByCourse.ValueMember = "ID";
                cmb_SearchByCourse.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }
        private void FilterByCources(int id)
        {
            try
            {

                DataTable dt = AdminManageExamService.GetExamsByCourse(id);
                dgv_Exam.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                dgv_Exam.DataSource = dt;
            }
        }
        private void cmb_SearchByCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SearchByCourse.SelectedIndex > 0)
            {
                //chb_Parctical.Checked = false;
                //chb_Final.Checked = false;
            }

            if (cmb_SearchByCourse.SelectedValue == null || cmb_SearchByCourse.SelectedIndex == 0)
            {
                DataTable dt = AdminManageExamService.GetAllExams();
                dgv_Exam.DataSource = dt;
                return;
            }
            int selectedCategory;
            if (int.TryParse(cmb_SearchByCourse.SelectedValue.ToString(), out selectedCategory))
            {
                FilterByCources(selectedCategory);

            }
            else
            {
                return;
            }
        }
        //no of stud && teacher not forget 
        private void chb_Final_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Final.Checked)
            {
                chb_Parctical.Checked = false;
                //cmb_SearchByCourse.SelectedIndex = 0;
            }
            DataTable dt = null;
            try
            {
                if (chb_Final.Checked)
                {
                    dt = AdminManageExamService.GetExamByType(1);
                }
                else
                {
                    dt = GetOriginalDataTable();
                }

                dgv_Exam.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                dt = GetOriginalDataTable();
                dgv_Exam.DataSource = dt;
            }

        }

        //filter by exam type
        private void chb_Parctical_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Parctical.Checked)
            {
                chb_Final.Checked = false;
                //cmb_SearchByCourse.SelectedIndex = 0;
            }
            DataTable dt = null;
            try
            {
                if (chb_Parctical.Checked)
                {
                    dt = AdminManageExamService.GetExamByType(0);
                }
                else
                {
                    dt = GetOriginalDataTable();
                }

                dgv_Exam.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                dt = GetOriginalDataTable();
                dgv_Exam.DataSource = dt;
            }

        }
        private DataTable GetOriginalDataTable()
        {
            return dt;
        }

        //--------------------------------filter by Date Time---------------------------------------
        private void FilterExams()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetExamByTime"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DateTime? startDate = dtp_FilterByStartTime.Checked ? dtp_FilterByStartTime.Value : (DateTime?)null;
                    DateTime? endDate = dtp_FilterByEndTime.Checked ? dtp_FilterByEndTime.Value : (DateTime?)null;

                    cmd.Parameters.AddWithValue("@s", (object)startDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@e", (object)endDate ?? DBNull.Value);

                    DataTable dt = AdminManageTeacherRepository.select(cmd);

                    dgv_Exam.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SearchByName_Click(object sender, EventArgs e)
        {
            FilterExams();
        }

        private void lbl_NoStud_Click(object sender, EventArgs e)
        {

        }
        //when click on cell get teacehr who put the exam and no of std 
        private void dgv_Exam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int examId;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Exam.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out examId))
                {
                    string teacherName = AdminManageExamService.GetTeacherNameByExamId(examId);
                    lbl_ExamTeacher.Text = $"Teacher: {teacherName}";
                    int studentCount = AdminManageExamService.GetStudentNumberPerExam(examId);
                    lbl_NoStud.Text = $"Number of Students: {studentCount}";
                }

            }
        }



        private void txb_ExamTeacher_TextChanged(object sender, EventArgs e)
        {

        }
        //report
        private void btn_Report_Click(object sender, EventArgs e)
        {
            AdminManageTeacherService.ExportToExcel(dgv_Exam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormAddExam formAddExam = new FormAddExam();
            //formAddExam.Show();
        }


        //filters 
        private void btn_Multi_Filters_Click(object sender, EventArgs e)
        {
            int? selectedCourseId = null;
            if (cmb_SearchByCourse.SelectedIndex > 0)
            {
                selectedCourseId = (int)cmb_SearchByCourse.SelectedValue;
            }


            DateTime? startDate = dtp_FilterByStartTime.Checked ? (DateTime?)dtp_FilterByStartTime.Value : null;
            DateTime? endDate = dtp_FilterByEndTime.Checked ? (DateTime?)dtp_FilterByEndTime.Value : null;

            bool isFinalChecked = chb_Final.Checked;    
            bool isPracticeChecked = chb_Parctical.Checked;

            //for test 
            //MessageBox.Show($"Course ID: {selectedCourseId}, Start Date: {startDate}, End Date: {endDate}, Is Final: {isFinalChecked}, Is Practice: {isPracticeChecked}");

            try
            {
                DataTable results = AdminManageExamService.FilterExamsBySelectors(
                    selectedCourseId,
                    startDate,
                    endDate,
                    isFinalChecked,
                    isPracticeChecked
                );

                if (results.Rows.Count > 0)
                {
                    dgv_Exam.DataSource = results;
                }
                else
                {
                    toastForm = new ToastForm(ToastType.Error, "No records found.");
                    toastForm.Show();
                    //MessageBox.Show("No records found.");
                }
            }
            catch (Exception ex)
            {
                toastForm = new ToastForm(ToastType.Error, "An error occurred.");
                toastForm.Show();
               // MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        //---------------------------Edit Exam by Id---------------------------------------------
    }
}
