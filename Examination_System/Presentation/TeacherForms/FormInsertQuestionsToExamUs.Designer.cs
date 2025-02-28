namespace Examination_System.Presentation.TeacherForms
{
    partial class FormInsertQuestionsToExamUs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            QuestionTypes = new CheckedListBox();
            dgvExams = new DataGridView();
            button2 = new Button();
            dgvQuestions = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            SuspendLayout();
            // 
            // QuestionTypes
            // 
            QuestionTypes.FormattingEnabled = true;
            QuestionTypes.Location = new Point(60, 62);
            QuestionTypes.Name = "QuestionTypes";
            QuestionTypes.Size = new Size(251, 114);
            QuestionTypes.TabIndex = 52;
            // 
            // dgvExams
            // 
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Location = new Point(508, 196);
            dgvExams.Name = "dgvExams";
            dgvExams.RowHeadersWidth = 51;
            dgvExams.Size = new Size(475, 452);
            dgvExams.TabIndex = 51;
            // 
            // button2
            // 
            button2.Location = new Point(441, 682);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(119, 42);
            button2.TabIndex = 50;
            button2.Text = "Save Exam";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnSave_Click;
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Location = new Point(3, 196);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.RowHeadersWidth = 51;
            dgvQuestions.Size = new Size(486, 452);
            dgvQuestions.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(60, 12);
            label7.Name = "label7";
            label7.Size = new Size(167, 31);
            label7.TabIndex = 48;
            label7.Text = "QuestionType ";
            // 
            // FormInsertQuestionsToExamUs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(QuestionTypes);
            Controls.Add(dgvExams);
            Controls.Add(button2);
            Controls.Add(dgvQuestions);
            Controls.Add(label7);
            MaximumSize = new Size(986, 749);
            MinimumSize = new Size(986, 749);
            Name = "FormInsertQuestionsToExamUs";
            Size = new Size(986, 749);
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox QuestionTypes;
        private DataGridView dgvExams;
        private Button button2;
        private DataGridView dgvQuestions;
        private Label label7;
    }
}
