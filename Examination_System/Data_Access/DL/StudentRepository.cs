using Examination_System;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Data_Access
{
    
        public class StudentRepository
        {
        private readonly string _connectionString = General.connectionString;

            private DataTable ExecuteStoredProcedure(string storedProcedure, SqlParameter[] parameters = null)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }

            public DataTable GetStudentsOfTeacher(int teacherId)
            {
                return ExecuteStoredProcedure("StudentsOfTeacher", new SqlParameter[]
                {
                new SqlParameter("@teacherid", SqlDbType.Int) { Value = teacherId }
                });
            }

            public DataTable GetStudentsByName(int teacherId, string firstName, string lastName)
            {
                return ExecuteStoredProcedure("GetStudentByName", new SqlParameter[]
                {
                new SqlParameter("@firstname", SqlDbType.VarChar) { Value = firstName },
                new SqlParameter("@lastname", SqlDbType.VarChar) { Value = string.IsNullOrEmpty(lastName) ? (object)DBNull.Value : lastName },
                new SqlParameter("@teacherid", SqlDbType.Int) { Value = teacherId }
                });
            }

            public DataTable GetStudentsByGender(int teacherId, int gender)
            {
                return ExecuteStoredProcedure("selectgender", new SqlParameter[]
                {
                new SqlParameter("@gender", SqlDbType.TinyInt) { Value = gender },
                new SqlParameter("@teacherid", SqlDbType.Int) { Value = teacherId }
                });
            }

            public DataTable GetStudentsByCourses(int teacherId, List<string> courses)
            {
                string selectedCourses = string.Join(",", courses);
                return ExecuteStoredProcedure("showStudentOfMultipleTheCourse", new SqlParameter[]
                {
                new SqlParameter("@coursenames", SqlDbType.VarChar) { Value = selectedCourses },
                new SqlParameter("@teacherid", SqlDbType.Int) { Value = teacherId }
                });
            }

            public List<string> GetTeacherCourses(int teacherId)
            {
                List<string> courses = new List<string>();
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand($"SELECT CourseName FROM Courses WHERE TeacherID = {teacherId}", con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            courses.Add(reader["CourseName"].ToString());
                        }
                    }
                }
                return courses;
            }
        public DataTable GetFilteredStudents(int teacherId, string name, int? gender, List<string> courses)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("FilterStudents", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = teacherId;

                    // Name filtering
                    if (!string.IsNullOrEmpty(name))
                    {
                        var parts = name.Trim().Split(' ');
                        cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = parts[0];
                        cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = parts.Length > 1 ? parts[1] : (object)DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = DBNull.Value;
                        cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    // Gender filtering
                    if (gender.HasValue)
                    {
                        cmd.Parameters.Add("@gender", SqlDbType.TinyInt).Value = gender.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("@gender", SqlDbType.TinyInt).Value = DBNull.Value;
                    }

                    // Courses filtering
                    if (courses != null && courses.Count > 0)
                    {
                        string selectedCourses = string.Join(",", courses);
                        cmd.Parameters.Add("@coursenames", SqlDbType.VarChar).Value = selectedCourses;
                    }
                    else
                    {
                        cmd.Parameters.Add("@coursenames", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }


    }
}

