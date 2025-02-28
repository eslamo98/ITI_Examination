namespace Examination_System.Presentation.TeacherForms
{
    partial class FormManageQuestionsUC
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            OneChoiceType = new CheckBox();
            label4 = new Label();
            cmbCourseName = new ComboBox();
            lbl_SearchByType = new Label();
            MultiChoiceType = new CheckBox();
            TrueFalseQuestion = new CheckBox();
            customPanel1 = new Examination_System.CustomControls.CustomPanel();
            dgvQuestions = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            SuspendLayout();
            // 
            // OneChoiceType
            // 
            OneChoiceType.AutoSize = true;
            OneChoiceType.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic);
            OneChoiceType.Location = new Point(51, 190);
            OneChoiceType.Margin = new Padding(2);
            OneChoiceType.Name = "OneChoiceType";
            OneChoiceType.Size = new Size(118, 24);
            OneChoiceType.TabIndex = 35;
            OneChoiceType.Text = "One Choice";
            OneChoiceType.UseVisualStyleBackColor = true;
            OneChoiceType.CheckedChanged += OneChoiceType_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(321, 111);
            label4.Name = "label4";
            label4.Size = new Size(124, 23);
            label4.TabIndex = 34;
            label4.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(321, 139);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(151, 28);
            cmbCourseName.TabIndex = 33;
            cmbCourseName.SelectedIndexChanged += cmbCourseName_SelectedIndexChanged_1;
            // 
            // lbl_SearchByType
            // 
            lbl_SearchByType.AutoSize = true;
            lbl_SearchByType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_SearchByType.Location = new Point(51, 80);
            lbl_SearchByType.Margin = new Padding(2, 0, 2, 0);
            lbl_SearchByType.Name = "lbl_SearchByType";
            lbl_SearchByType.Size = new Size(143, 23);
            lbl_SearchByType.TabIndex = 32;
            lbl_SearchByType.Text = "Search By Type";
            // 
            // MultiChoiceType
            // 
            MultiChoiceType.AutoSize = true;
            MultiChoiceType.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic);
            MultiChoiceType.Location = new Point(51, 151);
            MultiChoiceType.Margin = new Padding(2);
            MultiChoiceType.Name = "MultiChoiceType";
            MultiChoiceType.Size = new Size(150, 24);
            MultiChoiceType.TabIndex = 31;
            MultiChoiceType.Text = "Multiple Choice";
            MultiChoiceType.UseVisualStyleBackColor = true;
            MultiChoiceType.CheckedChanged += MultiChoiceType_CheckedChanged;
            // 
            // TrueFalseQuestion
            // 
            TrueFalseQuestion.AutoSize = true;
            TrueFalseQuestion.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TrueFalseQuestion.Location = new Point(51, 112);
            TrueFalseQuestion.Margin = new Padding(2);
            TrueFalseQuestion.Name = "TrueFalseQuestion";
            TrueFalseQuestion.Size = new Size(109, 24);
            TrueFalseQuestion.TabIndex = 30;
            TrueFalseQuestion.Text = "True False";
            TrueFalseQuestion.UseVisualStyleBackColor = true;
            TrueFalseQuestion.CheckedChanged += TrueFalseQuestion_CheckedChanged;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgvQuestions);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.RoyalBlue;
            customPanel1.GradientTopColor = Color.Transparent;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(22, 230);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 13);
            customPanel1.Size = new Size(947, 496);
            customPanel1.TabIndex = 36;
            // 
            // dgvQuestions
            // 
            dgvQuestions.AllowUserToAddRows = false;
            dgvQuestions.AllowUserToDeleteRows = false;
            dgvQuestions.AllowUserToResizeColumns = false;
            dgvQuestions.AllowUserToResizeRows = false;
            dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvQuestions.BackgroundColor = Color.White;
            dgvQuestions.BorderStyle = BorderStyle.None;
            dgvQuestions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.Padding = new Padding(15);
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvQuestions.DefaultCellStyle = dataGridViewCellStyle5;
            dgvQuestions.Dock = DockStyle.Fill;
            dgvQuestions.EnableHeadersVisualStyles = false;
            dgvQuestions.Location = new Point(0, 0);
            dgvQuestions.Margin = new Padding(3, 4, 3, 4);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvQuestions.RowHeadersVisible = false;
            dgvQuestions.RowHeadersWidth = 25;
            dgvQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestions.Size = new Size(947, 483);
            dgvQuestions.TabIndex = 0;
            dgvQuestions.CellContentClick += dgvQuestions_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label1.Location = new Point(274, 29);
            label1.Name = "label1";
            label1.Size = new Size(424, 45);
            label1.TabIndex = 37;
            label1.Text = "Manage Your Questions";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(670, 133);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(299, 44);
            button1.TabIndex = 38;
            button1.Text = "Add New Question";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(718, 59);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(196, 44);
            button2.TabIndex = 39;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += this.button2_Click_1;
            // 
            // FormManageQuestionsUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(customPanel1);
            Controls.Add(OneChoiceType);
            Controls.Add(label4);
            Controls.Add(cmbCourseName);
            Controls.Add(lbl_SearchByType);
            Controls.Add(MultiChoiceType);
            Controls.Add(TrueFalseQuestion);
            MaximumSize = new Size(986, 749);
            MinimumSize = new Size(986, 749);
            Name = "FormManageQuestionsUC";
            Size = new Size(986, 749);
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox OneChoiceType;
        private Label label4;
        private ComboBox cmbCourseName;
        private Label lbl_SearchByType;
        private CheckBox MultiChoiceType;
        private CheckBox TrueFalseQuestion;
        private DataGridView dgvQuestions;
        private Button button2;
        private Button button1;
        private CustomControls.CustomPanel customPanel1;
        private DataGridView dataGridView1;
        private CustomControls.CustomPanel customPanel2;
        private DataGridView dgvExams;
        private Label label1;
    }
}
