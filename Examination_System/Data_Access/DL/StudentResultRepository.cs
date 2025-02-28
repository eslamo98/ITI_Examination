using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace ExaminationSystem.Data_Access
{
    public class StudentResultRepository
    {
        private readonly string _connectionString = "Data Source=.;Initial Catalog=myExam;Integrated Security=True;Trust Server Certificate=True";

        public DataTable GetStudentResults(int studentId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ShowResult", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = studentId;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
