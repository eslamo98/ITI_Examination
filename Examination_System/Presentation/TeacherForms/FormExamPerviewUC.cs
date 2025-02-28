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
using Examination_System.Business;
using ExaminationSystem.Data_Access.Models;

namespace Examination_System.Presentation.TeacherForms
{
    public partial class FormExamPerviewUC: UserControl
    {
        private Exam _exam;
        private QuestionList _questions;
        public FormExamPerviewUC(Exam exam)
        {
            InitializeComponent();
            _exam = exam;
            _questions = LoadQuestions();

            LoadExamInfo();
            LoadQuestionsUI();

        }
        private QuestionList LoadQuestions()
        {
            return _exam.QuestionList;
        }
        private void LoadExamInfo()
        {
            flowPanelExamInfo.Controls.Clear();

            flowPanelExamInfo.Controls.Add(CreateInfoLabel($"Course Name: {CourseService.GetCourseNameByCourseID(_exam.CourseID)}", true));
            flowPanelExamInfo.Controls.Add(CreateInfoLabel($"Duration: {_exam.Duration} min"));
            flowPanelExamInfo.Controls.Add(CreateInfoLabel($"Total Marks: {_exam.Marks}"));
            flowPanelExamInfo.Controls.Add(CreateInfoLabel($"Exam Date: {_exam.StartTime}"));
        }

        private Label CreateInfoLabel(string text, bool isBold = false)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Arial", isBold ? 14 : 12, isBold ? FontStyle.Bold : FontStyle.Regular),
                AutoSize = true
            };
        }
        private void LoadQuestionsUI()
        {
            flowPanelQuestions.Controls.Clear();
            int i = 1;
            foreach(Question question in _questions) 
            { 
                Panel questionPanel = new Panel
                {
                    AutoSize = true,
                    Padding = new Padding(10),
                    Width = flowPanelQuestions.Width - 30,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                Label lblQuestion = new Label
                {
                    Text = $"{i}. {question.Body}",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Margin = new Padding(10, 10, 10, 10)
                };

                questionPanel.Controls.Add(lblQuestion);

                FlowLayoutPanel answersPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.TopDown,
                    Padding = new Padding(50, 50, 10, 10)
                };

                foreach (var answer in question.AnswerList)
                {
                    Control answerControl;

                    if (question.Type == QuestionType.SingleChoice || question.Type == QuestionType.TrueOrFalse)
                    {
                        answerControl = new RadioButton
                        {
                            Text = answer.AnswerText,
                            AutoSize = true,
                            Checked = answer.IsAnswerCorrect,
                            Enabled = false
                        };
                    }
                    else
                    {
                        answerControl = new CheckBox
                        {
                            Text = answer.AnswerText,
                            AutoSize = true,
                            Checked = answer.IsAnswerCorrect,
                            Enabled = false
                        };
                    }

                    answerControl.Margin = new Padding(20, 2, 2, 2);
                    answersPanel.Controls.Add(answerControl);
                }
                questionPanel.Controls.Add(answersPanel);
                flowPanelQuestions.Controls.Add(questionPanel);
                i++;
            }
        }
    }
}





