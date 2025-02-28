using Examination_System;
using Examination_System.Business.Enums;

using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;


namespace ExaminationSystem.Data_Access
{
    internal class QuestionRepository
    {

        public static int AddQuestion(Question question, SqlConnection connection, SqlTransaction transaction)
        {
            SqlCommand cmd = new("AddQuestion", connection, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@CourseID", question.CourseID);
            cmd.Parameters.AddWithValue("@Body", question.Body);
            cmd.Parameters.AddWithValue("@QuestionType", question.Type);
            cmd.Parameters.AddWithValue("@Marks", question.Marks);

            SqlParameter outputParam = new("@QuestionID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputParam);

            cmd.ExecuteNonQuery();
            return (int)outputParam.Value; // Return the new QuestionID
        }
        public static DataTable GetQuestionsbyExamID(int ExamID)
        {
            DataTable dataTable = new();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new("GetQuestionsByExamID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ExamID", ExamID);
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public static DataTable GetAllQuestionByCourseID(int CourseID)
        {
            DataTable dataTable = new();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new("GetAllQuestionByCourseID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public static DataTable GetAllQuestionsNotInExambyCourseID(int CourseID, int ExamID, List<QuestionType>? questionType = null)
        {
            DataTable dataTable = new();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new("GetAllQuestionsNotInExambyCourseID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@ExamID", ExamID);
                    string typeString = (questionType is null || questionType.Count == 0)
                        ? DBNull.Value.ToString()
                        : string.Join(",", questionType.Select(t => (int)t));
                    cmd.Parameters.AddWithValue("@QuestionType", string.IsNullOrEmpty(typeString) ? DBNull.Value : typeString);


                    SqlDataAdapter da = new(cmd);
                    da.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public static DataTable GetAllQuestions()
        {
            string query = "SELECT * FROM Questions";
            DatabaseHelper db = new();
            return db.Executequery(query);
        }
        public static Question GetQuestionWithID(int QuestionID)
        {
            string query = $"SELECT * FROM Questions Where ID = {QuestionID}";
            DatabaseHelper db = new();
            DataTable resultTable = db.Executequery(query);
            if (resultTable.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DataRow row = resultTable.Rows[0];
                Question question = new()
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Body = row["Body"].ToString(),
                    Type = (QuestionType)Convert.ToInt32(row["QuestionType"]),
                    CourseID = Convert.ToInt32(row["CourseID"]),
                    Marks = Convert.ToInt32(row["Marks"])
                };
                return question;
            }
        }
        public static DataTable GetQuestionsWithFilters(int TeacherID,List<QuestionType>? questionType, int? CourseID)
        {
            DataTable dataTable = new();
            using (SqlConnection con = new(General.connectionString))
            {
                using SqlCommand cmd = new("GetQuestionsWithFilters", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID);

                cmd.Parameters.AddWithValue("@CourseID", CourseID ?? (object)DBNull.Value);

                string typeString = (questionType is null || questionType.Count == 0)
                    ? DBNull.Value.ToString()
                    : string.Join(",", questionType.Select(t => (int)t));

                cmd.Parameters.AddWithValue("@QuestionType", string.IsNullOrEmpty(typeString) ? DBNull.Value : typeString);

                SqlDataAdapter da = new(cmd);
                da.Fill(dataTable);
            }
            return dataTable;

        }
        public static void DisableQuestionWithID(int QuestionID)
        {
            using (SqlConnection con = new(General.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new("DisableQuestionWithID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@QuestionID", QuestionID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool UpdateQuestionWithID(int QuestionID, string body, int marks, AnswerList answers)
        {
            using (SqlConnection con = new(General.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new("UpdateQuestionWithID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@QuestionID", QuestionID);
                    cmd.Parameters.AddWithValue("@Body", body);
                    cmd.Parameters.AddWithValue("@Marks", marks);
                    cmd.ExecuteNonQuery();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0) return false;
                }
                foreach(var answer in answers)
                {
                    using (SqlCommand cmd = new("UpdateAnswer", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AnswerID", answer.ID);
                        cmd.Parameters.AddWithValue("@QuestionID", QuestionID);
                        cmd.Parameters.AddWithValue("@Text", answer.AnswerText);
                        cmd.Parameters.AddWithValue("@IsCorrect", answer.IsAnswerCorrect);
                        cmd.ExecuteNonQuery(); // Execute for each answer
                    }
                }
            }
            return true;
        }
    }
}





