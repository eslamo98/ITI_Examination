using Examination_System.Business.Enums;
using Examination_System.Data_Access.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Examination_System.Data_Access
{
    public static class UserRepository
    {
        private static readonly string connectionString = General.connectionString;
        public static Tuple<int, User> GetLogin(string emailOrUsernamr, string userPassword)
        {
            User user = new User();
            int status = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("getLogin", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //input params
                        cmd.Parameters.AddWithValue("usernameOrEmail", emailOrUsernamr);
                        cmd.Parameters.AddWithValue("pass", userPassword);

                        //output params
                        SqlParameter userID = new SqlParameter("userID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter userRole = new SqlParameter("userRole", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter gender = new SqlParameter("gender", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter firstName = new SqlParameter("firstName", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                        SqlParameter lastName = new SqlParameter("lastName", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                        SqlParameter username = new SqlParameter("username", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };
                        SqlParameter email = new SqlParameter("email", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                        SqlParameter UserImg = new SqlParameter("UserImg", SqlDbType.VarBinary, -1) { Direction = ParameterDirection.Output };
                        SqlParameter SSN = new SqlParameter("SSN", SqlDbType.NVarChar, 15) { Direction = ParameterDirection.Output };
                        SqlParameter password = new SqlParameter("password", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output };
                        SqlParameter statusCode = new SqlParameter("status", SqlDbType.Int) { Direction = ParameterDirection.Output };

                        cmd.Parameters.AddRange(new SqlParameter[]
                        {
                        userID,
                        userRole,
                        firstName,
                        lastName,
                        username,
                        email,
                        UserImg,
                        SSN,
                        password,
                        statusCode, 
                        gender
                        });
                        con.Open();

                        cmd.ExecuteNonQuery();
                        con.Close();
                        status = (int) statusCode.Value ;
                        if (status == 0)
                        {
                            user.Email = email.Value.ToString();
                            user.UserRole = (UserRole)(int)userRole.Value;
                            user.Gender = (Gender)(int)gender.Value;
                            user.PasswordHash = password.Value.ToString();
                            user.SSN = SSN.Value.ToString();
                            user.FirstName = firstName.Value.ToString();
                            user.LastName = lastName.Value.ToString();
                            user.Username = username.Value.ToString();
                            user.UserImg = UserImg.Value as byte[];
                            user.ID = (int)userID.Value;

                        }
                    }
                }

                Tuple<int, User> result = new Tuple<int, User>(status, user);
                
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int CreateUpdateUser(User user, List<int> coursesIds, OperationMode operationMode = OperationMode.Create)
        {
            int result = -1;
            try
            {
                string storedProcName = "";
                if (operationMode == OperationMode.Create && user.UserRole == UserRole.Student) {
                    storedProcName = "CreateStudentWithCourses";
                }else if(operationMode == OperationMode.Edit && user.UserRole == UserRole.Student)
                {
                    storedProcName = "updateStudentDataWithCourses";
                }else if(operationMode == OperationMode.Create && user.UserRole == UserRole.Teacher)
                {
                    storedProcName = "CreateTeacherWithCourses";

                }
                else if (operationMode == OperationMode.Edit && user.UserRole == UserRole.Teacher)
                {
                    storedProcName = "updateTeacherCoursesData";

                }
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using(SqlCommand cmd = new SqlCommand(storedProcName))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //input params
                        if(operationMode == OperationMode.Edit)
                        {
                            if(user.UserRole == UserRole.Student)
                            {
                                cmd.Parameters.AddWithValue("studentId", user.ID);
                            } else
                            {
                                cmd.Parameters.AddWithValue("teacherId", user.ID);

                            }
                        }
                        cmd.Parameters.AddWithValue("Username", user.Username);
                        cmd.Parameters.AddWithValue("Email", user.Email);
                        cmd.Parameters.AddWithValue("PasswordHash", user.PasswordHash);
                        cmd.Parameters.AddWithValue("UserRole", user.UserRole);
                        cmd.Parameters.AddWithValue("SSN", user.SSN);
                        cmd.Parameters.AddWithValue("FirstName", user.FirstName);
                        cmd.Parameters.AddWithValue("LastName", user.LastName);
                        cmd.Parameters.AddWithValue("UserImg",  user.UserImg);
                        cmd.Parameters.AddWithValue("Gender", user.Gender);

                        SqlParameter outputStatus = new SqlParameter("@Status", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputStatus);

                        SqlParameter error = new SqlParameter("@error", SqlDbType.NVarChar, 225)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(error);

                        DataTable coursesTable = new DataTable();
                        coursesTable.Columns.Add("CourseId", typeof(int));
                        foreach (int courseId in coursesIds)
                        {
                            coursesTable.Rows.Add(courseId);
                        }

                        SqlParameter coursesTableParam = cmd.Parameters.AddWithValue("@CourseIds", coursesTable);
                        coursesTableParam.SqlDbType = SqlDbType.Structured;
                        coursesTableParam.TypeName = "[dbo].[CourseIdTableType]";
                        con.Open();

                        cmd.ExecuteNonQuery(); // Use ExecuteNonQuery since no result set is returned

                        result = (int)outputStatus.Value;
                        con.Close();
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        

        public static int DeleteUsrById(int userId)
        {
            int result = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("deleteUserById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("userId", userId);

                        SqlParameter sqlresult = new SqlParameter("result", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        cmd.Parameters.Add(sqlresult);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        result = (int)sqlresult.Value;
                        con.Close();
                    }
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static User GetUsrById(int userId)
        {

            User user = new User();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetUsrById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //input params
                        cmd.Parameters.AddWithValue("Id", userId);
                        SqlParameter userID = new SqlParameter("userID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter userRole = new SqlParameter("userRole", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter gender = new SqlParameter("gender", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter firstName = new SqlParameter("firstName", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                        SqlParameter lastName = new SqlParameter("lastName", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                        SqlParameter username = new SqlParameter("username", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };
                        SqlParameter email = new SqlParameter("email", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                        SqlParameter UserImg = new SqlParameter("UserImg", SqlDbType.VarBinary, -1) { Direction = ParameterDirection.Output };
                        SqlParameter SSN = new SqlParameter("SSN", SqlDbType.NVarChar, 15) { Direction = ParameterDirection.Output };
                        SqlParameter password = new SqlParameter("password", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output };

                        cmd.Parameters.AddRange(new SqlParameter[]
                        {
                        userID,
                        userRole,
                        firstName,
                        lastName,
                        username,
                        email,
                        UserImg,
                        SSN,
                        password,
                        gender
                        });
                        con.Open();

                        cmd.ExecuteNonQuery(); // Use ExecuteNonQuery since no result set is returned

                        con.Close();

                        user.Email = email.Value.ToString();
                        user.UserRole = (UserRole)(int)userRole.Value;
                        user.Gender = (Gender)(int)gender.Value;
                        user.PasswordHash = password.Value.ToString();
                        user.SSN = SSN.Value.ToString();
                        user.FirstName = firstName.Value.ToString();
                        user.LastName = lastName.Value.ToString();
                        user.Username = username.Value.ToString();
                        user.UserImg = UserImg.Value as byte[];
                        user.ID = (int)userID.Value;
                        }
                    }


                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int UpdateUserData( User updatedUser)
        {
            
            int status = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("updateUserData", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //input params
                        cmd.Parameters.AddWithValue("Id", updatedUser.ID);
                        cmd.Parameters.AddWithValue("Username", updatedUser.Username);
                        cmd.Parameters.AddWithValue("Email", updatedUser.Email);
                        cmd.Parameters.AddWithValue("PasswordHash", updatedUser.PasswordHash);
                        cmd.Parameters.AddWithValue("UserRole", updatedUser.UserRole);
                        cmd.Parameters.AddWithValue("SSN", updatedUser.SSN);
                        cmd.Parameters.AddWithValue("FirstName", updatedUser.FirstName);
                        cmd.Parameters.AddWithValue("LastName", updatedUser.LastName);
                        cmd.Parameters.AddWithValue("UserImg", updatedUser.UserImg);
                        cmd.Parameters.AddWithValue("Gender", updatedUser.Gender);

                        SqlParameter outputStatus = new SqlParameter("@Status", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputStatus);

                        
                        con.Open();

                        cmd.ExecuteNonQuery(); // Use ExecuteNonQuery since no result set is returned

                        status = (int)outputStatus.Value;
                        con.Close();
                        
                    }
                }

                

                return status;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable GetAllTeachers()
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("getAllTeachers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);

                }
            }

            return table;
        }

        public static DataTable GetAllStudents()
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection con = new(General.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("getAllStudents", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(table);

                    }
                }

                return table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        public static DataTable FilterStudents(int teacherId, int courseId)
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection con = new(General.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("FilterStudents", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("teacherId", teacherId);
                        cmd.Parameters.AddWithValue("courseId", courseId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(table);

                    }
                }

                return table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable GetAllStudentsByTeacherId(int teacherId)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("getAllStudentsByTeacherId", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("teacherId", teacherId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);

                }
            }

            return table;
        }

        public static DataTable GetStudentsByCourseId(int courseId)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("getStudentsByCourseId", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("courseId", courseId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);

                }
            }

            return table;
        }

        public static DataTable GetStudentsByTeacherAndCourse(int courseId, int teacherId)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("getStudentsByTeacherAndCourse", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("courseId", courseId);
                    cmd.Parameters.AddWithValue("teacherId", teacherId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);

                }
            }

            return table;
        }
        public static DataTable GetAllCoursesStudentEnrolledIn(int studentId)
        {
            try
            {
                DataTable table = new DataTable();
                using (SqlConnection con = new(General.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetAllCoursesStudentEnrolledIn", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("studentId", studentId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(table);
                    }
                }

                return table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable UserDAL(SqlCommand cmd)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd.Connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
