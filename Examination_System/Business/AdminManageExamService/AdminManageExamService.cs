using System.Data;
using Examination_System.Data_Access;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Excel = Microsoft.Office.Interop.Excel;

namespace Examination_System.Business.AdminManageExamService
{
    internal class AdminManageExamService
    {
        public static string connection_string = General.connectionString;
        public static DataTable GetAllExams()
        {
            SqlCommand cmd = new SqlCommand($"GetAllExams");
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = AdminManageTeacherRepository.select(cmd);
            return dt;
        }

        public static DataTable GetAll_Courses()
        {
            SqlCommand cmd = new SqlCommand($"GetAllCourses");
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = AdminManageTeacherRepository.select(cmd);
            return dt;
        }

        public static DataTable GetExamsByCourse(int _id)
        {
            SqlCommand cmd = new SqlCommand($"GetExamsByCourse");
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = AdminManageTeacherRepository.select(cmd);
            return dt;
        }

        public static DataTable GetExamByType(int _t)
        {
            SqlCommand cmd = new SqlCommand($"GetExamByType");
            cmd.Parameters.AddWithValue("@t", _t);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = AdminManageTeacherRepository.select(cmd);
            return dt;
        }
        public static string GetTeacherNameByExamId(int examId)
        {
            string teacherName = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(connection_string))
                {
                    using (SqlCommand cmd = new SqlCommand("GetExamTeacher", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", examId);
                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                            teacherName = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return teacherName;
        }

        //public static  DataTable FilterExamsByTeacher(string _t)
        //{

        //    DataTable dt=new DataTable();
        //    try
        //    {

        //            using (SqlCommand cmd = new SqlCommand($"GetExamByTeacherName"))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue(" @TeacherName", _t);
        //                dt = Data_Access.AdminManageTeachers.AdminManageTeacherRepository.select(cmd);

        //            }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return dt;
        //}


        public static int GetStudentNumberPerExam(int examId)
        {
            int studentCount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connection_string)) 
                {
                    using (SqlCommand cmd = new SqlCommand("GetStudentNumberPerExam", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", examId); 

                        conn.Open();
                        object result = cmd.ExecuteScalar(); 

                        if (result != null && int.TryParse(result.ToString(), out int count))
                        {
                            studentCount = count;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentCount;
        }

        public static void ExportToExcel(DataGridView dgv)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
            Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

            // Adding column headers
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                excelWorksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            // Adding rows
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    excelWorksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Save the Excel file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelWorkbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Report created successfully!");
            }

            // Clean up
            excelWorkbook.Close();
            excelApp.Quit();
        }



      //filter by miltible selectors 

        public static DataTable FilterExamsBySelectors(
     int? courseId,
     DateTime? startDate,
     DateTime? endDate,
     bool isFinalChecked,
     bool isPracticeChecked)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("FilterExamsBySelectors"))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CourseID", (object)courseId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@StartDate", (object)startDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EndDate", (object)endDate ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@IsFinal", isFinalChecked ? (byte)1 : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IsPractice", isPracticeChecked ? (byte)0 : (object)DBNull.Value);

                dt = AdminManageTeacherRepository.select(cmd);
            }
            return dt;
        }




    }
}
