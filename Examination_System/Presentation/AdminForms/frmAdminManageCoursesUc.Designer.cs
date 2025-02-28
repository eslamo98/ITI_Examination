namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminManageCoursesUc
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
            dgv_courses = new DataGridView();
            customPanel1 = new CustomControls.CustomPanel();
            btn_newstudent = new Button();
            tx_coursename = new TextBox();
            label1 = new Label();
            com_teachers = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.AllowUserToAddRows = false;
            dgv_courses.AllowUserToDeleteRows = false;
            dgv_courses.AllowUserToResizeColumns = false;
            dgv_courses.AllowUserToResizeRows = false;
            dgv_courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_courses.BackgroundColor = Color.White;
            dgv_courses.BorderStyle = BorderStyle.None;
            dgv_courses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_courses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_courses.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_courses.Dock = DockStyle.Fill;
            dgv_courses.EnableHeadersVisualStyles = false;
            dgv_courses.Location = new Point(0, 0);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_courses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_courses.RowHeadersVisible = false;
            dgv_courses.RowHeadersWidth = 25;
            dgv_courses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_courses.Size = new Size(813, 455);
            dgv_courses.TabIndex = 0;
            dgv_courses.CellClick += dgv_courses_CellContentClick;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgv_courses);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(20, 65);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(813, 465);
            customPanel1.TabIndex = 16;
            // 
            // btn_newstudent
            // 
            btn_newstudent.Location = new Point(647, 30);
            btn_newstudent.Name = "btn_newstudent";
            btn_newstudent.Size = new Size(186, 23);
            btn_newstudent.TabIndex = 13;
            btn_newstudent.Text = "create new Course";
            btn_newstudent.UseVisualStyleBackColor = true;
            btn_newstudent.Click += btn_newstudent_Click;
            // 
            // tx_coursename
            // 
            tx_coursename.Location = new Point(88, 32);
            tx_coursename.Name = "tx_coursename";
            tx_coursename.Size = new Size(124, 23);
            tx_coursename.TabIndex = 17;
            tx_coursename.TextChanged += tx_coursename_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 18;
            label1.Text = "Course";
            // 
            // com_teachers
            // 
            com_teachers.FormattingEnabled = true;
            com_teachers.Location = new Point(317, 32);
            com_teachers.Name = "com_teachers";
            com_teachers.Size = new Size(121, 23);
            com_teachers.TabIndex = 20;
            com_teachers.SelectedIndexChanged += com_teachers_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(232, 32);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 19;
            label2.Text = "Teachers";
            // 
            // frmAdminManageCoursesUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(com_teachers);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tx_coursename);
            Controls.Add(customPanel1);
            Controls.Add(btn_newstudent);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminManageCoursesUc";
            Size = new Size(863, 562);
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_courses;
        private CustomControls.CustomPanel customPanel1;
        private Button btn_newstudent;
        private TextBox tx_coursename;
        private Label label1;
        private ComboBox com_teachers;
        private Label label2;
    }
}
