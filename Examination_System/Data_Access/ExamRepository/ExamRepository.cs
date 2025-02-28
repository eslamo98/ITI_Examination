using Examination_System;
using Examination_System.Data_Access;
using ExaminationSystem;
using ExaminationSystem.Business.Enums;
using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExaminationSystem.Data_Access
{
    internal class ExamRepository
    {
        private static readonly string connectionString = General.connectionString;
        private static readonly SqlConnection con = new SqlConnection(connectionString);

        private static  DatabaseHelper dl = new DatabaseHelper();
        public static int CreateExam(Exam exam)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("CreateExam", connection, transaction)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@CourseID", exam.CourseID);
                        command.Parameters.AddWithValue("@Duration", exam.Duration);
                        command.Parameters.AddWithValue("@StartDate", exam.StartTime);
                        command.Parameters.AddWithValue("@EndDate", exam.EndTime);
                        command.Parameters.AddWithValue("@ExamType", exam.Type);
                        command.Parameters.AddWithValue("@NoOfQuestions", exam.NoOfQuestions);


                        SqlParameter outputParam = new SqlParameter("@ExamID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);
                        command.ExecuteNonQuery();
                        int createdExamID = (int)outputParam.Value;
                        transaction.Commit();

                        return createdExamID;

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to create exam.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }

                    finally
                    {
                        transaction.Dispose();
                    }
                }
            }
        }

        public static DataTable select(SqlCommand _cmd)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_cmd);
                _cmd.Connection = con;
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        public static int EditExam(Exam exam)
        {
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand($"UpdateExam");
                cmd.Parameters.AddWithValue("@ExamID", exam.ID);
                cmd.Parameters.AddWithValue("@CourseID", exam.CourseID);
                cmd.Parameters.AddWithValue("@Type", exam.Type);
                cmd.Parameters.AddWithValue("@StartTime", exam.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", exam.EndTime);
                cmd.Parameters.AddWithValue("@Duration", exam.Duration);
                cmd.Parameters.AddWithValue("@NoOfQuestions", exam.NoOfQuestions);
                cmd.CommandType = CommandType.StoredProcedure;
                result = AdminManageTeacherRepository.DML(cmd);
                int UpdatedExamID = exam.ID;
                MessageBox.Show($"Exam Updated Successfully!\nExam ID: {UpdatedExamID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create exam.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return result;
        }
        public static int DML(SqlCommand _cmd)
        {
            try
            {
                int result = 0;
                _cmd.Connection = con;
                con.Open();
                result = _cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        public static DataTable GetExamById(int examID)
        {
            string query = $"SELECT * FROM Exam WHERE ID = {examID}";
            return dl.Executequery(query);
        }
    }
}


 