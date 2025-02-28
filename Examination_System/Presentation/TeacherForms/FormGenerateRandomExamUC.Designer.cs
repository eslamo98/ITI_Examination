namespace Examination_System.Presentation.TeacherForms
{
    partial class FormGenerateRandomExamUC
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
            panel1 = new Panel();
            label1 = new Label();
            NumTFQuestions = new NumericUpDown();
            label3 = new Label();
            NumChooseOneQuestion = new NumericUpDown();
            label2 = new Label();
            NumChooseMultipleQuestion = new NumericUpDown();
            btnContinue = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumTFQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseOneQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseMultipleQuestion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnContinue);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(NumTFQuestions);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NumChooseOneQuestion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(NumChooseMultipleQuestion);
            panel1.Location = new Point(240, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 350);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 3;
            label1.Text = "True False ";
            // 
            // NumTFQuestions
            // 
            NumTFQuestions.Location = new Point(196, 20);
            NumTFQuestions.Name = "NumTFQuestions";
            NumTFQuestions.Size = new Size(198, 27);
            NumTFQuestions.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.Location = new Point(23, 206);
            label3.Name = "label3";
            label3.Size = new Size(137, 19);
            label3.TabIndex = 5;
            label3.Text = "Choose Multiple ";
            // 
            // NumChooseOneQuestion
            // 
            NumChooseOneQuestion.Location = new Point(196, 111);
            NumChooseOneQuestion.Name = "NumChooseOneQuestion";
            NumChooseOneQuestion.Size = new Size(198, 27);
            NumChooseOneQuestion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.Location = new Point(23, 111);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 4;
            label2.Text = "Choose One";
            // 
            // NumChooseMultipleQuestion
            // 
            NumChooseMultipleQuestion.Location = new Point(196, 198);
            NumChooseMultipleQuestion.Name = "NumChooseMultipleQuestion";
            NumChooseMultipleQuestion.Size = new Size(198, 27);
            NumChooseMultipleQuestion.TabIndex = 2;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Black;
            btnContinue.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(62, 283);
            btnContinue.Margin = new Padding(3, 4, 3, 4);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(310, 53);
            btnContinue.TabIndex = 26;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(74, 77);
            label4.Name = "label4";
            label4.Size = new Size(799, 38);
            label4.TabIndex = 27;
            label4.Text = "Select How Many Questions Per Type to be Generated";
            // 
            // FormGenerateRandomExamUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "FormGenerateRandomExamUC";
            Size = new Size(921, 668);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumTFQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseOneQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseMultipleQuestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private NumericUpDown NumTFQuestions;
        private Label label3;
        private NumericUpDown NumChooseOneQuestion;
        private Label label2;
        private NumericUpDown NumChooseMultipleQuestion;
        private Button btnContinue;
        private Label label4;
    }
}
