
using Examination_System.Data_Access;
using Microsoft.Data.SqlClient;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;


namespace Examination_System.Business
{
    internal class AdminManageTeacherService
    {
        public static DataTable GetAllTeachers(int _role)
        {
            //Data_Access.Models.User _user = new Data_Access.Models.User() {UserRole=UserRole.Teacher};
            SqlCommand cmd = new SqlCommand($"GetAllTeacher");
            cmd.Parameters.AddWithValue("@role", _role);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = AdminManageTeacherRepository.select(cmd);
            return dt ;
        }
        public static DataTable Search_ById(int _id)
        {
            SqlCommand cmd = new SqlCommand($"SearchByID");
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = AdminManageTeacherRepository.select(cmd);
            return dt;
        }
        public static DataTable Search_ByName(string _name)
        {
            SqlCommand cmd = new SqlCommand($"SearchByName");
            cmd.Parameters.AddWithValue("@name", _name);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = AdminManageTeacherRepository.select(cmd);
            return dt;
        }

        public static DataTable GetAll_Courses()
        {
            SqlCommand cmd = new SqlCommand($"getAllCourses");
           // cmd.Parameters.AddWithValue("@id", _id);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = AdminManageTeacherRepository.select(cmd);
            return dt;
        }

        public static DataTable Search_ByCourse(int _id)
        {
            SqlCommand cmd = new SqlCommand($"SearchByCourses");
             cmd.Parameters.AddWithValue("@id", _id);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = AdminManageTeacherRepository.select(cmd);
            return dt;
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




    }
}
