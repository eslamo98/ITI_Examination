using Examination_System;
using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;
using System.Data;


namespace ExaminationSystem.Data_Access
{
    internal class AnswerRepository
    {
        public static void AddAnswer(int questionId, Answer answer, SqlConnection connection, SqlTransaction transaction)
        {
            SqlCommand cmd = new SqlCommand("AddAnswer", connection, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@QuestionID", questionId);
            cmd.Parameters.AddWithValue("@AnswerText", answer.AnswerText);
            cmd.Parameters.AddWithValue("@IsCorrect", answer.IsAnswerCorrect);

            cmd.ExecuteNonQuery();
        }

        public static DataTable GetAnswerbyQuestionID(int QuestionID)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetAnswersByQuestionID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@QuestionID", QuestionID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public static bool ClearQuestionAnswers(int questionId)
        {
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new("ClearQuestionAnswers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@QuestionID", questionId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
    }
}
