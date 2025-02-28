using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Examination_System.Business.StudentExamHistory
{
    class StudentExamService
    {
        private string connString = General.connectionString;

        public DataTable GetStudentExams(int stdID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("select distinct e.ID,cr.CourseName, e.StartTime, e.EndTime, e.NoOFQuestions, e.Duration,e.TotalMarks,\r\ncase when e.[ExamType]=0 then 'PracticeExam'else 'FinalExam' end as examtype,\r\ncase when e.[Status] =0 then 'Pending' when e.[ExamType]=1 then 'Started' else 'Finished' end as examstatus\r\nfrom Exam e join StudentCourses sc on e.CourseID = sc.CourseID join Courses cr on e.CourseID=cr.ID\r\nwhere sc.StudentID = @StudentID  and e.StartTime < GETDATE()", conn))
                    {
                        cmd.Parameters.AddWithValue("StudentID", stdID);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error happened: " + ex.Message);
            }

            return dt;
        }
    }
}
