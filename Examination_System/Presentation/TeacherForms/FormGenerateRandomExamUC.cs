using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_System.Business.Enums;
using ExaminationSystem.Business.ExamQuestionService;
using ExaminationSystem.Data_Access.Models;
using ExaminationSystem.Data_Access;
using Examination_System.Presentation.AdminForms;
using Examination_System.Presentation.Common;

namespace Examination_System.Presentation.TeacherForms
{
    public partial class FormGenerateRandomExamUC : UserControl
    {
        private Exam _exam;
        private int TotalQuestionsSelected = 0;
        public FormGenerateRandomExamUC(Exam exam)
        {
            InitializeComponent();
            _exam = exam;
            NumChooseMultipleQuestion.ValueChanged += ValidateTotalQuestions;
            NumChooseOneQuestion.ValueChanged += ValidateTotalQuestions;
            NumTFQuestions.ValueChanged += ValidateTotalQuestions;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            LoadExamQuestions();
        }
        private void LoadExamQuestions()
        {
            QuestionList questions = [];
            QuestionList questionsTF = ExamQuestionService.GetRandomExamQuestionsList(_exam.CourseID, QuestionType.TrueOrFalse, (int)NumTFQuestions.Value);
            QuestionList questionsCO = ExamQuestionService.GetRandomExamQuestionsList(_exam.CourseID, QuestionType.SingleChoice, (int)NumChooseOneQuestion.Value);
            QuestionList questionsCM = ExamQuestionService.GetRandomExamQuestionsList(_exam.CourseID, QuestionType.MultipleChoice, (int)NumChooseMultipleQuestion.Value);

            questions.AddRange(questionsTF);
            questions.AddRange(questionsCO);
            questions.AddRange(questionsCM);
            _exam.QuestionList = questions;
            ExamQuestionService.SaveExamQuestions(_exam.ID, questions);
            DataTable exam = ExamRepository.GetExamById(_exam.ID);
            if (exam.Rows.Count > 0)
            {
                _exam.Marks = Convert.ToInt32(exam.Rows[0]["TotalMarks"]);
            }
            
            FormReset();
            General.LoadUserControl(new FormExamPerviewUC(_exam));
            Hide();
        }
        private void FormReset()
        {
            NumChooseMultipleQuestion.Value = 0;
            NumChooseOneQuestion.Value = 0;
            NumChooseMultipleQuestion.Value = 0;
        }
        private void DisableNumericControls(object sender)
        {
            int excess = TotalQuestionsSelected - _exam.NoOfQuestions;
            if (sender == NumChooseMultipleQuestion)
            {
                NumChooseMultipleQuestion.Value -= excess;
            }
            else if (sender == NumChooseOneQuestion)
            {
                NumChooseOneQuestion.Value -= excess;
            }
            else if (sender == NumTFQuestions)
            {
                NumTFQuestions.Value -= excess;
            }
        }
        private void ValidateTotalQuestions(object sender, EventArgs e)
        {
            TotalQuestionsSelected = (int)(NumChooseMultipleQuestion.Value + NumChooseOneQuestion.Value + NumTFQuestions.Value);
            if (TotalQuestionsSelected > _exam.NoOfQuestions)
            {
                DisableNumericControls(sender);
                new ToastForm(ToastType.Warning, $"Total questions exceeded. You can only select up to {_exam.NoOfQuestions} questions.").Show();
            }
        }
    }
}