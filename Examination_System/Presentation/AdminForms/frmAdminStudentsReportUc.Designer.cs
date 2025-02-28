namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminStudentsReportUc
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
            dgv_students = new DataGridView();
            customPanel1 = new CustomControls.CustomPanel();
            button2 = new Button();
            button1 = new Button();
            btn_back = new Button();
            label2 = new Label();
            com_teachers = new ComboBox();
            label1 = new Label();
            com_courses = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            customPanel1.SuspendLayout();
            SuspendLayout();
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
            dgv_students.Size = new Size(802, 452);
            dgv_students.TabIndex = 0;
            dgv_students.CellClick += Handle_View_Courses;
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
            customPanel1.Location = new Point(30, 73);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(802, 462);
            customPanel1.TabIndex = 22;
            // 
            // button2
            // 
            button2.Location = new Point(235, 27);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 24;
            button2.Text = "Generate PDF";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(101, 27);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 23;
            button1.Text = "Generate Excel File";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(5, 27);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 6;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(599, 27);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 28;
            label2.Text = "Teachers";
            // 
            // com_teachers
            // 
            com_teachers.FormattingEnabled = true;
            com_teachers.Location = new Point(690, 27);
            com_teachers.Name = "com_teachers";
            com_teachers.Size = new Size(121, 23);
            com_teachers.TabIndex = 27;
            com_teachers.SelectedIndexChanged += FiltersChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 26;
            label1.Text = "Courses";
            // 
            // com_courses
            // 
            com_courses.FormattingEnabled = true;
            com_courses.Location = new Point(458, 24);
            com_courses.Name = "com_courses";
            com_courses.Size = new Size(121, 23);
            com_courses.TabIndex = 25;
            com_courses.SelectedIndexChanged += FiltersChanged;
            // 
            // frmAdminStudentsReportUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(com_teachers);
            Controls.Add(label1);
            Controls.Add(com_courses);
            Controls.Add(btn_back);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(customPanel1);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminStudentsReportUc";
            Size = new Size(863, 562);
            Load += frmAdminStudentsReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_students;
        private CustomControls.CustomPanel customPanel1;
        private Button button2;
        private Button button1;
        private Button btn_back;
        private Label label2;
        private ComboBox com_teachers;
        private Label label1;
        private ComboBox com_courses;
    }
}
