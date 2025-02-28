namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminManageStudentUc
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            com_courses = new ComboBox();
            label2 = new Label();
            com_teachers = new ComboBox();
            dgv_students = new DataGridView();
            customPanel1 = new Examination_System.CustomControls.CustomPanel();
            btn_newstudent = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 11;
            label1.Text = "Teachers";
            // 
            // com_courses
            // 
            com_courses.FormattingEnabled = true;
            com_courses.Location = new Point(333, 31);
            com_courses.Margin = new Padding(3, 4, 3, 4);
            com_courses.Name = "com_courses";
            com_courses.Size = new Size(143, 28);
            com_courses.TabIndex = 9;
            com_courses.SelectedIndexChanged += com_teachers_course_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(256, 33);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 12;
            label2.Text = "Courses";
            // 
            // com_teachers
            // 
            com_teachers.FormattingEnabled = true;
            com_teachers.Location = new Point(111, 31);
            com_teachers.Margin = new Padding(3, 4, 3, 4);
            com_teachers.Name = "com_teachers";
            com_teachers.Size = new Size(138, 28);
            com_teachers.TabIndex = 15;
            com_teachers.SelectedIndexChanged += com_teachers_course_SelectedIndexChanged;
            // 
            // dgv_students
            // 
            dgv_students.AllowUserToAddRows = false;
            dgv_students.AllowUserToDeleteRows = false;
            dgv_students.AllowUserToResizeColumns = false;
            dgv_students.AllowUserToResizeRows = false;
            dgv_students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_students.BackgroundColor = Color.White;
            dgv_students.BorderStyle = BorderStyle.None;
            dgv_students.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_students.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_students.Dock = DockStyle.Fill;
            dgv_students.EnableHeadersVisualStyles = false;
            dgv_students.Location = new Point(0, 0);
            dgv_students.Margin = new Padding(3, 4, 3, 4);
            dgv_students.Name = "dgv_students";
            dgv_students.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_students.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_students.RowHeadersVisible = false;
            dgv_students.RowHeadersWidth = 25;
            dgv_students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_students.Size = new Size(922, 607);
            dgv_students.TabIndex = 0;
            dgv_students.CellClick += HandleEDD_Buttons_Click;
            dgv_students.CellContentClick += dgv_students_CellContentClick;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgv_students);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(32, 87);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 13);
            customPanel1.Size = new Size(922, 620);
            customPanel1.TabIndex = 16;
            // 
            // btn_newstudent
            // 
            btn_newstudent.Location = new Point(495, 29);
            btn_newstudent.Margin = new Padding(3, 4, 3, 4);
            btn_newstudent.Name = "btn_newstudent";
            btn_newstudent.Size = new Size(213, 31);
            btn_newstudent.TabIndex = 13;
            btn_newstudent.Text = "create new student";
            btn_newstudent.UseVisualStyleBackColor = true;
            btn_newstudent.Click += btn_newstudent_Click;
            // 
            // frmAdminManageStudentUc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customPanel1);
            Controls.Add(com_teachers);
            Controls.Add(btn_newstudent);
            Controls.Add(label1);
            Controls.Add(com_courses);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(986, 749);
            MinimumSize = new Size(986, 749);
            Name = "frmAdminManageStudentUc";
            Size = new Size(986, 749);
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox com_courses;
        private Label label2;
        private ComboBox com_teachers;
        private DataGridView dgv_students;
        private CustomControls.CustomPanel customPanel1;
        private Button btn_newstudent;
    }
}
