using Examination_System.Data_Access;
using Examination_System.Presentation.Common;
using ExaminationSystem.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_System.Business.Enums;
using Microsoft.VisualBasic.Devices;

namespace Examination_System.Business
{
    public static class CourseService
    {
        public static DataTable GetAllCourses()
        {
            return CourseRepository.GetAllCourses();
        }
        public static CreateEditCourseStatus DeleteCourseById(int courseId)
        {
            SqlCommand cmd = new SqlCommand("DeleteCourse");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CourseId", courseId);
            SqlParameter status = new SqlParameter("@status", SqlDbType.Int) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(status);
            Reposatory.DML(cmd);
            return (CreateEditCourseStatus)(int)status.Value;
        }

        public static DataTable GetAllCoursesData(int teacherId = 0, string courseName= "")
        {
            try
            {
                if (teacherId == 0 && string.IsNullOrEmpty(courseName))
                {
                    return Reposatory.select(new Microsoft.Data.SqlClient.SqlCommand(@$"select c.*, CONCAT(u.FirstName, SPACE(1), u.LastName) as Teacher from courses c 
                        join users u 
                        on c.TeacherID = u.ID"));
                } else if (teacherId != 0 && string.IsNullOrEmpty(courseName))
                {
                    return Reposatory.select(new Microsoft.Data.SqlClient.SqlCommand(@$"select c.*, CONCAT(u.FirstName, SPACE(1), u.LastName) as Teacher from courses c 
                        join users u 
                        on c.TeacherID = u.ID
                        where c.TeacherID = {teacherId}
                        "));
                } else if (teacherId == 0 && !string.IsNullOrEmpty(courseName))
                {
                    return Reposatory.select(new Microsoft.Data.SqlClient.SqlCommand(@$"select c.*, CONCAT(u.FirstName, SPACE(1), u.LastName) as Teacher from courses c 
                        join users u 
                        on c.TeacherID = u.ID
                        where c.CourseName like '%{courseName}%'
                        "));
                } else
                {
                    return Reposatory.select(new Microsoft.Data.SqlClient.SqlCommand(@$"select c.*, CONCAT(u.FirstName, SPACE(1), u.LastName) as Teacher from courses c 
                        join users u 
                        on c.TeacherID = u.ID
                        where c.CourseName like '%{courseName}%'
                        and c.TeacherID = {teacherId}
                        "));
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public static Course GetCourseById(int courseId)
        {
            try
            {
                var courseDt =  Reposatory.select(new SqlCommand(@$"Select * from Courses where ID = {courseId}"));
                if(courseDt.Rows.Count > 0)
                {
                    DataRow row = courseDt.Rows[0]; 

                    Course course = new Course
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Name = row["CourseName"].ToString(),
                        TeacherID = row["TeacherID"] != DBNull.Value ?  Convert.ToInt32(row["TeacherID"]) : 0,
                        Grade = row["Grade"] != DBNull.Value ? Convert.ToInt32(row["Grade"]): default,
                        Duration = row["Duration"] != DBNull.Value ? Convert.ToInt32(row["Duration"]): default
                    };

                    return course;
                } else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static CreateEditCourseStatus CreateCourse(Course course)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("CreateCourse");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CourseName", course.Name);
                cmd.Parameters.AddWithValue("TeacherID", course.TeacherID);
                cmd.Parameters.AddWithValue("Grade", course.Grade);
                cmd.Parameters.AddWithValue("Duration", course.Duration);
                SqlParameter status = new SqlParameter("@status", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(status);
                Reposatory.DML(cmd);
                return (CreateEditCourseStatus)(int)status.Value;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static CreateEditCourseStatus UpdateCourse(Course course)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateCourse");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CourseId", course.ID);
                cmd.Parameters.AddWithValue("CourseName", course.Name);
                cmd.Parameters.AddWithValue("TeacherID", course.TeacherID);
                cmd.Parameters.AddWithValue("Grade", course.Grade);
                cmd.Parameters.AddWithValue("Duration", course.Duration);
                SqlParameter status = new SqlParameter("@status", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(status);
                Reposatory.DML(cmd);
                return (CreateEditCourseStatus)(int)status.Value;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable GetAllCoursesWithTeacherID(int teacherID)
        {
            return CourseRepository.GetAllCoursesWithTeacherID(teacherID);
        }
        public static List<Course> GetAllCoursesListWithTeacherID(int teacherID)
        {
            return CourseRepository.GetAllCoursesListWithTeacherID(teacherID);
        }
        public static string GetCourseNameByCourseID(int courseID)
        {
            return CourseRepository.GetCourseNameByCourseID(courseID);
        }
    }
}
