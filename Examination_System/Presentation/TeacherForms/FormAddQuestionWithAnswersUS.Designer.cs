namespace Examination_System.Presentation.TeacherForms
{
    partial class FormAddQuestionWithAnswersUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddQuestionWithAnswersUS));
            cmbCourseName = new ComboBox();
            MarksUpDown = new NumericUpDown();
            AnswerPanel = new Panel();
            cmbQuestionTypes = new ComboBox();
            txtQuestionBody = new RichTextBox();
            customPanel1 = new Examination_System.CustomControls.CustomPanel();
            label1 = new Label();
            btn_back = new Button();
            Add = new Label();
            btn_save = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MarksUpDown).BeginInit();
            customPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(191, 29);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(168, 28);
            cmbCourseName.TabIndex = 27;
            cmbCourseName.SelectedIndexChanged += cmbCourseName_SelectedIndexChanged;
            // 
            // MarksUpDown
            // 
            MarksUpDown.Location = new Point(191, 99);
            MarksUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MarksUpDown.Name = "MarksUpDown";
            MarksUpDown.Size = new Size(168, 27);
            MarksUpDown.TabIndex = 26;
            MarksUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AnswerPanel
            // 
            AnswerPanel.AutoScroll = true;
            AnswerPanel.AutoSize = true;
            AnswerPanel.BackColor = Color.Transparent;
            AnswerPanel.Location = new Point(519, 262);
            AnswerPanel.Name = "AnswerPanel";
            AnswerPanel.Size = new Size(406, 310);
            AnswerPanel.TabIndex = 25;
            AnswerPanel.Paint += AnswerPanel_Paint;
            // 
            // cmbQuestionTypes
            // 
            cmbQuestionTypes.FormattingEnabled = true;
            cmbQuestionTypes.Location = new Point(191, 172);
            cmbQuestionTypes.Name = "cmbQuestionTypes";
            cmbQuestionTypes.Size = new Size(168, 28);
            cmbQuestionTypes.TabIndex = 20;
            cmbQuestionTypes.SelectedIndexChanged += CmbQuestionTypes_SelectedIndexChanged;
            // 
            // txtQuestionBody
            // 
            txtQuestionBody.Location = new Point(152, 240);
            txtQuestionBody.Name = "txtQuestionBody";
            txtQuestionBody.Size = new Size(307, 51);
            txtQuestionBody.TabIndex = 19;
            txtQuestionBody.Text = "";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(btn_back);
            customPanel1.Controls.Add(Add);
            customPanel1.Controls.Add(AnswerPanel);
            customPanel1.Controls.Add(btn_save);
            customPanel1.Controls.Add(panel1);
            customPanel1.Controls.Add(pictureBox1);
            customPanel1.ForeColor = Color.White;
            customPanel1.GradientBottomColor = Color.LightCyan;
            customPanel1.GradientTopColor = Color.SlateGray;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(21, 14);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(946, 711);
            customPanel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(612, 220);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 29;
            label1.Text = "Select Your Answer";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Black;
            btn_back.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(78, 637);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(310, 53);
            btn_back.TabIndex = 3;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // Add
            // 
            Add.AutoSize = true;
            Add.BackColor = Color.Transparent;
            Add.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(338, 88);
            Add.Name = "Add";
            Add.Size = new Size(339, 45);
            Add.TabIndex = 26;
            Add.Text = "Add New Question";
            Add.Click += Add_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Black;
            btn_save.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(575, 637);
            btn_save.Margin = new Padding(3, 4, 3, 4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(296, 53);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += BtnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbQuestionTypes);
            panel1.Controls.Add(MarksUpDown);
            panel1.Controls.Add(txtQuestionBody);
            panel1.Controls.Add(cmbCourseName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(29, 262);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 310);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 244);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 29;
            label2.Text = "Question Body";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 172);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 28;
            label4.Text = "Question Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(28, 102);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 5;
            label6.Text = "Marks";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(22, 31);
            label8.Name = "label8";
            label8.Size = new Size(108, 19);
            label8.TabIndex = 0;
            label8.Text = "Course Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAddQuestionWithAnswersUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customPanel1);
            MaximumSize = new Size(986, 749);
            MinimumSize = new Size(986, 749);
            Name = "FormAddQuestionWithAnswersUS";
            Size = new Size(986, 749);
            ((System.ComponentModel.ISupportInitialize)MarksUpDown).EndInit();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbCourseName;
        private NumericUpDown MarksUpDown;
        private Panel AnswerPanel;
        private ComboBox cmbQuestionTypes;
        private RichTextBox txtQuestionBody;
        private CustomControls.CustomPanel customPanel1;
        private Button btn_back;
        private Button btn_save;
        private Panel panel1;
        private Label label6;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Label Add;
        private Label label1;
    }
}
