using ExaminationSystem.Data_Access;
using ExaminationSystem.Data_Access.Models;

using System.Data;


namespace ExaminationSystem.Business.AnswerService
{
    internal class AnswerService
    {
        public static DataTable GetAnswerbyQuestionID(int questionID)
        {
            return AnswerRepository.GetAnswerbyQuestionID(questionID);
        }
        public static AnswerList GetAnswerListbyQuestionID(int questionID)
        {
            DataTable dataTable = GetAnswerbyQuestionID(questionID);
            return ConvertDataTableAnswersToList(dataTable);
        }
        public static AnswerList ConvertDataTableAnswersToList(DataTable dataTable)
        {
            AnswerList answerList = new AnswerList();
            foreach (DataRow row in dataTable.Rows)
            {
                answerList.Add(new Answer
                {
                    ID = (int)row["ID"],
                    QuestionID = (int)row["QuestionID"],
                    AnswerText = row["AnswerText"].ToString(),
                    IsAnswerCorrect = (bool)row["IsCorrect"]
                });
            }
            return answerList;
        }

        public static bool ClearQuestionAnswers(int questionId)
        {
            return AnswerRepository.ClearQuestionAnswers(questionId);
        }
    }
}

