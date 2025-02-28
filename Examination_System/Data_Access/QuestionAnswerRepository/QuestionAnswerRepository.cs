using Examination_System;
using ExaminationSystem.Data_Access;
using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;
using System.Data;


namespace ExaminationSystem.DAL.QuestionAnswerRepo
{
    internal static class QuestionAnswerRepository
    {
        private static string connectionString = General.connectionString;
        public static void AddQuestionWithAnswers(Question question, AnswerList answers)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insert Questions 
                    int questionId = QuestionRepository.AddQuestion(question,connection,transaction);

                    //Insert Answers
                    foreach (var answer in answers)
                    {
                        AnswerRepository.AddAnswer(questionId, answer, connection, transaction);
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
        }

    }
}
