using ExaminationSystem.Data_Access;
using ExaminationSystem.Data_Access.Models;
using System.Data;


namespace ExaminationSystem.Business.StudentResultService
{
    public class StudentResultService
    {
        private readonly StudentResultRepository _studentResultRepository;

        public StudentResultService()
        {
            _studentResultRepository = new StudentResultRepository();
        }

        public DataTable GetStudentResults(int studentId)
        {
            return _studentResultRepository.GetStudentResults(studentId);
        }
    }
}
