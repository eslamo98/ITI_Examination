namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminStudentExamsUc
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
            customPanel1 = new CustomControls.CustomPanel();
            dgv_student_exams = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            btn_back = new Button();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_student_exams).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgv_student_exams);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(31, 75);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(811, 462);
            customPanel1.TabIndex = 17;
            // 
            // dgv_student_exams
            // 
            dgv_student_exams.AllowUserToAddRows = false;
            dgv_student_exams.AllowUserToDeleteRows = false;
            dgv_student_exams.AllowUserToResizeColumns = false;
            dgv_student_exams.AllowUserToResizeRows = false;
            dgv_student_exams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_student_exams.BackgroundColor = Color.White;
            dgv_student_exams.BorderStyle = BorderStyle.None;
            dgv_student_exams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_student_exams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_student_exams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_student_exams.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_student_exams.Dock = DockStyle.Fill;
            dgv_student_exams.EnableHeadersVisualStyles = false;
            dgv_student_exams.Location = new Point(0, 0);
            dgv_student_exams.Name = "dgv_student_exams";
            dgv_student_exams.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_student_exams.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_student_exams.RowHeadersVisible = false;
            dgv_student_exams.RowHeadersWidth = 25;
            dgv_student_exams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_student_exams.Size = new Size(811, 452);
            dgv_student_exams.TabIndex = 0;
            dgv_student_exams.CellClick += Handle_Show_Exam;
            // 
            // button2
            // 
            button2.Location = new Point(246, 28);
            button2.Name = "button2";
            button2.Size = new Size(103, 23);
            button2.TabIndex = 24;
            button2.Text = "Generate PDF";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(112, 28);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 23;
            button1.Text = "Generate Excel File";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(31, 28);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 22;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // frmAdminStudentExamsUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(customPanel1);
            Controls.Add(button1);
            Controls.Add(btn_back);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminStudentExamsUc";
            Size = new Size(863, 562);
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_student_exams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel customPanel1;
        private DataGridView dgv_student_exams;
        private Button button2;
        private Button button1;
        private Button btn_back;
    }
}
