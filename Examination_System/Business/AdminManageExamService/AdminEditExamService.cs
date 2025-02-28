using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_System.Data_Access;
using ExaminationSystem.Business.Enums;
using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;

namespace Examination_System.Business.AdminManageExamService
{
    public class AdminEditExamService
    {
        public static string connection_string = General.connectionString;

        public static string GetCourseNameById(int courseId)
        {
            string courseName = string.Empty;
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetCourseNameByCourseID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CourseID", courseId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        courseName = result.ToString();
                    }
                }
            }
            return courseName;
        }



        public static Exam GetExamById(int _id)
        {
            Exam exam = null;
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetExamByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", _id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            exam = new Exam
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                CourseID = Convert.ToInt32(reader["CourseID"]),
                                Type = (ExamType)Convert.ToInt32(reader["ExamType"]),
                                StartTime = Convert.ToDateTime(reader["StartTime"]),
                                EndTime = Convert.ToDateTime(reader["EndTime"]),
                                Duration = Convert.ToInt32(reader["Duration"]),
                                Status = (ExamStatus)Convert.ToInt32(reader["Status"]),
                                NoOfQuestions = Convert.ToInt32(reader["NoOfQuestions"])
                            };
                        }
                        reader.Close();
                        return exam;
                    }
                }
            }      
        }

        public static int DeleteExam(int examId)
        {
            int result = 0;
            using (SqlCommand cmd = new SqlCommand("DeleteExamById"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ExamID", examId);
                try
                {
                    result = AdminManageTeacherRepository.DML(cmd);
                    return result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return result;
                }
            }
        }


    }
}
