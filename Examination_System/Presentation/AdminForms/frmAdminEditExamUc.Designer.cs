namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminEditExamUc
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
            btn_SaveChanges = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbCourseName = new ComboBox();
            label5 = new Label();
            combinedDateTimePickerStart = new ExaminationSystem.CombinedDateTimePicker();
            label3 = new Label();
            numDuration = new NumericUpDown();
            NoOfQuestionsUpDown = new Label();
            UpDownNoOFQuestions = new NumericUpDown();
            label6 = new Label();
            btn_Back = new Button();
            rdoFinalExam = new RadioButton();
            btn_EditQuestions = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            combinedDateTimePickerEnd = new ExaminationSystem.CombinedDateTimePicker();
            rdoPracticeExam = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownNoOFQuestions).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_SaveChanges
            // 
            btn_SaveChanges.Location = new Point(499, 168);
            btn_SaveChanges.Margin = new Padding(2);
            btn_SaveChanges.Name = "btn_SaveChanges";
            btn_SaveChanges.Size = new Size(211, 34);
            btn_SaveChanges.TabIndex = 39;
            btn_SaveChanges.Text = "Save Changes";
            btn_SaveChanges.UseVisualStyleBackColor = true;
            btn_SaveChanges.Click += btn_SaveChanges_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 145);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 31;
            label2.Text = "Exam Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 89);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 30;
            label1.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            cmbCourseName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCourseName.Enabled = false;
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(157, 116);
            cmbCourseName.Margin = new Padding(3, 2, 3, 2);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(133, 23);
            cmbCourseName.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "StartDate";
            // 
            // combinedDateTimePickerStart
            // 
            combinedDateTimePickerStart.Location = new Point(65, 3);
            combinedDateTimePickerStart.Margin = new Padding(4, 3, 4, 3);
            combinedDateTimePickerStart.Name = "combinedDateTimePickerStart";
            combinedDateTimePickerStart.Size = new Size(433, 99);
            combinedDateTimePickerStart.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 105);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Duration";
            // 
            // numDuration
            // 
            numDuration.Location = new Point(62, 107);
            numDuration.Margin = new Padding(3, 2, 3, 2);
            numDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(438, 23);
            numDuration.TabIndex = 4;
            // 
            // NoOfQuestionsUpDown
            // 
            NoOfQuestionsUpDown.AutoSize = true;
            NoOfQuestionsUpDown.Location = new Point(338, 98);
            NoOfQuestionsUpDown.Name = "NoOfQuestionsUpDown";
            NoOfQuestionsUpDown.Size = new Size(93, 15);
            NoOfQuestionsUpDown.TabIndex = 33;
            NoOfQuestionsUpDown.Text = "No of Questions";
            // 
            // UpDownNoOFQuestions
            // 
            UpDownNoOFQuestions.Location = new Point(338, 116);
            UpDownNoOFQuestions.Margin = new Padding(3, 2, 3, 2);
            UpDownNoOFQuestions.Name = "UpDownNoOFQuestions";
            UpDownNoOFQuestions.Size = new Size(132, 23);
            UpDownNoOFQuestions.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 132);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 13;
            label6.Text = "End Date";
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(157, 35);
            btn_Back.Margin = new Padding(2);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(211, 27);
            btn_Back.TabIndex = 38;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // rdoFinalExam
            // 
            rdoFinalExam.AutoSize = true;
            rdoFinalExam.Location = new Point(153, 168);
            rdoFinalExam.Margin = new Padding(3, 2, 3, 2);
            rdoFinalExam.Name = "rdoFinalExam";
            rdoFinalExam.Size = new Size(82, 19);
            rdoFinalExam.TabIndex = 36;
            rdoFinalExam.TabStop = true;
            rdoFinalExam.Text = "Final Exam";
            rdoFinalExam.UseVisualStyleBackColor = true;
            // 
            // btn_EditQuestions
            // 
            btn_EditQuestions.Location = new Point(499, 116);
            btn_EditQuestions.Margin = new Padding(3, 2, 3, 2);
            btn_EditQuestions.Name = "btn_EditQuestions";
            btn_EditQuestions.Size = new Size(211, 31);
            btn_EditQuestions.TabIndex = 35;
            btn_EditQuestions.Text = "Edit Question";
            btn_EditQuestions.UseVisualStyleBackColor = true;
            btn_EditQuestions.Click += btn_EditQuestions_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(combinedDateTimePickerStart);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(numDuration);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(combinedDateTimePickerEnd);
            flowLayoutPanel1.Location = new Point(153, 215);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(557, 258);
            flowLayoutPanel1.TabIndex = 34;
            // 
            // combinedDateTimePickerEnd
            // 
            combinedDateTimePickerEnd.Location = new Point(64, 135);
            combinedDateTimePickerEnd.Margin = new Padding(4, 3, 4, 3);
            combinedDateTimePickerEnd.Name = "combinedDateTimePickerEnd";
            combinedDateTimePickerEnd.Size = new Size(402, 102);
            combinedDateTimePickerEnd.TabIndex = 16;
            // 
            // rdoPracticeExam
            // 
            rdoPracticeExam.AutoSize = true;
            rdoPracticeExam.Location = new Point(153, 185);
            rdoPracticeExam.Margin = new Padding(3, 2, 3, 2);
            rdoPracticeExam.Name = "rdoPracticeExam";
            rdoPracticeExam.Size = new Size(99, 19);
            rdoPracticeExam.TabIndex = 37;
            rdoPracticeExam.TabStop = true;
            rdoPracticeExam.Text = "Practice Exam";
            rdoPracticeExam.UseVisualStyleBackColor = true;
            // 
            // frmAdminEditExamUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_SaveChanges);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCourseName);
            Controls.Add(NoOfQuestionsUpDown);
            Controls.Add(UpDownNoOFQuestions);
            Controls.Add(btn_Back);
            Controls.Add(rdoFinalExam);
            Controls.Add(btn_EditQuestions);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(rdoPracticeExam);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminEditExamUc";
            Size = new Size(863, 562);
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownNoOFQuestions).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_SaveChanges;
        private Label label2;
        private Label label1;
        private ComboBox cmbCourseName;
        private Label label5;
        private ExaminationSystem.CombinedDateTimePicker combinedDateTimePickerStart;
        private Label label3;
        private NumericUpDown numDuration;
        private Label NoOfQuestionsUpDown;
        private NumericUpDown UpDownNoOFQuestions;
        private Label label6;
        private Button btn_Back;
        private RadioButton rdoFinalExam;
        private Button btn_EditQuestions;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExaminationSystem.CombinedDateTimePicker combinedDateTimePickerEnd;
        private RadioButton rdoPracticeExam;
    }
}
