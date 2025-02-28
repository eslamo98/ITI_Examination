namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminManageExamsUc
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
            btn_Multi_Filters = new Button();
            btn_Report = new Button();
            lbl_ExamTeacher = new Label();
            lbl_NoStud = new Label();
            btn_SearchByName = new Button();
            dtp_FilterByEndTime = new DateTimePicker();
            dtp_FilterByStartTime = new DateTimePicker();
            lbl_SearchByType = new Label();
            chb_Parctical = new CheckBox();
            chb_Final = new CheckBox();
            cmb_SearchByCourse = new ComboBox();
            button1 = new Button();
            customPanel1 = new CustomControls.CustomPanel();
            dgv_Exam = new DataGridView();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Exam).BeginInit();
            SuspendLayout();
            // 
            // btn_Multi_Filters
            // 
            btn_Multi_Filters.Location = new Point(189, 149);
            btn_Multi_Filters.Margin = new Padding(2);
            btn_Multi_Filters.Name = "btn_Multi_Filters";
            btn_Multi_Filters.Size = new Size(118, 20);
            btn_Multi_Filters.TabIndex = 28;
            btn_Multi_Filters.Text = "Select and Filter";
            btn_Multi_Filters.UseVisualStyleBackColor = true;
            btn_Multi_Filters.Click += btn_Multi_Filters_Click;
            // 
            // btn_Report
            // 
            btn_Report.Location = new Point(483, 84);
            btn_Report.Margin = new Padding(2);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new Size(194, 20);
            btn_Report.TabIndex = 27;
            btn_Report.Text = "Report";
            btn_Report.UseVisualStyleBackColor = true;
            btn_Report.Click += btn_Report_Click;
            // 
            // lbl_ExamTeacher
            // 
            lbl_ExamTeacher.AutoSize = true;
            lbl_ExamTeacher.Location = new Point(37, 114);
            lbl_ExamTeacher.Margin = new Padding(2, 0, 2, 0);
            lbl_ExamTeacher.Name = "lbl_ExamTeacher";
            lbl_ExamTeacher.Size = new Size(47, 15);
            lbl_ExamTeacher.TabIndex = 26;
            lbl_ExamTeacher.Text = "Teacher";
            // 
            // lbl_NoStud
            // 
            lbl_NoStud.AutoSize = true;
            lbl_NoStud.Location = new Point(37, 84);
            lbl_NoStud.Margin = new Padding(2, 0, 2, 0);
            lbl_NoStud.Name = "lbl_NoStud";
            lbl_NoStud.Size = new Size(109, 15);
            lbl_NoStud.TabIndex = 25;
            lbl_NoStud.Text = "Number of Student";
            // 
            // btn_SearchByName
            // 
            btn_SearchByName.Location = new Point(37, 149);
            btn_SearchByName.Margin = new Padding(2);
            btn_SearchByName.Name = "btn_SearchByName";
            btn_SearchByName.Size = new Size(127, 20);
            btn_SearchByName.TabIndex = 24;
            btn_SearchByName.Text = "Search By Date";
            btn_SearchByName.UseVisualStyleBackColor = true;
            btn_SearchByName.Click += btn_SearchByName_Click;
            // 
            // dtp_FilterByEndTime
            // 
            dtp_FilterByEndTime.Location = new Point(259, 80);
            dtp_FilterByEndTime.Margin = new Padding(2);
            dtp_FilterByEndTime.Name = "dtp_FilterByEndTime";
            dtp_FilterByEndTime.ShowCheckBox = true;
            dtp_FilterByEndTime.Size = new Size(211, 23);
            dtp_FilterByEndTime.TabIndex = 23;
            // 
            // dtp_FilterByStartTime
            // 
            dtp_FilterByStartTime.Location = new Point(259, 49);
            dtp_FilterByStartTime.Margin = new Padding(2);
            dtp_FilterByStartTime.Name = "dtp_FilterByStartTime";
            dtp_FilterByStartTime.ShowCheckBox = true;
            dtp_FilterByStartTime.Size = new Size(211, 23);
            dtp_FilterByStartTime.TabIndex = 22;
            // 
            // lbl_SearchByType
            // 
            lbl_SearchByType.AutoSize = true;
            lbl_SearchByType.Location = new Point(170, 49);
            lbl_SearchByType.Margin = new Padding(2, 0, 2, 0);
            lbl_SearchByType.Name = "lbl_SearchByType";
            lbl_SearchByType.Size = new Size(85, 15);
            lbl_SearchByType.TabIndex = 21;
            lbl_SearchByType.Text = "Search By Type";
            // 
            // chb_Parctical
            // 
            chb_Parctical.AutoSize = true;
            chb_Parctical.Location = new Point(172, 109);
            chb_Parctical.Margin = new Padding(2);
            chb_Parctical.Name = "chb_Parctical";
            chb_Parctical.Size = new Size(71, 19);
            chb_Parctical.TabIndex = 20;
            chb_Parctical.Text = "Practical";
            chb_Parctical.UseVisualStyleBackColor = true;
            chb_Parctical.CheckedChanged += chb_Parctical_CheckedChanged;
            // 
            // chb_Final
            // 
            chb_Final.AutoSize = true;
            chb_Final.Location = new Point(172, 80);
            chb_Final.Margin = new Padding(2);
            chb_Final.Name = "chb_Final";
            chb_Final.Size = new Size(83, 19);
            chb_Final.TabIndex = 19;
            chb_Final.Text = "Final Exam";
            chb_Final.UseVisualStyleBackColor = true;
            chb_Final.CheckedChanged += chb_Final_CheckedChanged;
            // 
            // cmb_SearchByCourse
            // 
            cmb_SearchByCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_SearchByCourse.FormattingEnabled = true;
            cmb_SearchByCourse.Location = new Point(483, 46);
            cmb_SearchByCourse.Margin = new Padding(2);
            cmb_SearchByCourse.Name = "cmb_SearchByCourse";
            cmb_SearchByCourse.Size = new Size(190, 23);
            cmb_SearchByCourse.TabIndex = 18;
            cmb_SearchByCourse.SelectedIndexChanged += cmb_SearchByCourse_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(37, 43);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 16;
            button1.Text = "create new exam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgv_Exam);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(25, 196);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(813, 325);
            customPanel1.TabIndex = 29;
            // 
            // dgv_Exam
            // 
            dgv_Exam.AllowUserToAddRows = false;
            dgv_Exam.AllowUserToDeleteRows = false;
            dgv_Exam.AllowUserToResizeColumns = false;
            dgv_Exam.AllowUserToResizeRows = false;
            dgv_Exam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_Exam.BackgroundColor = Color.White;
            dgv_Exam.BorderStyle = BorderStyle.None;
            dgv_Exam.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Exam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Exam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Exam.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Exam.Dock = DockStyle.Fill;
            dgv_Exam.EnableHeadersVisualStyles = false;
            dgv_Exam.Location = new Point(0, 0);
            dgv_Exam.Name = "dgv_Exam";
            dgv_Exam.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Exam.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Exam.RowHeadersVisible = false;
            dgv_Exam.RowHeadersWidth = 25;
            dgv_Exam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Exam.Size = new Size(813, 315);
            dgv_Exam.TabIndex = 0;
            dgv_Exam.CellClick += dgv_Exam_CellClick;
            // 
            // frmAdminManageExamsUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customPanel1);
            Controls.Add(btn_Multi_Filters);
            Controls.Add(btn_Report);
            Controls.Add(lbl_ExamTeacher);
            Controls.Add(lbl_NoStud);
            Controls.Add(btn_SearchByName);
            Controls.Add(dtp_FilterByEndTime);
            Controls.Add(dtp_FilterByStartTime);
            Controls.Add(lbl_SearchByType);
            Controls.Add(chb_Parctical);
            Controls.Add(chb_Final);
            Controls.Add(cmb_SearchByCourse);
            Controls.Add(button1);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminManageExamsUc";
            Size = new Size(863, 562);
            Load += frmAdminManageExams_Load;
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Exam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Multi_Filters;
        private Button btn_Report;
        private Label lbl_ExamTeacher;
        private Label lbl_NoStud;
        private Button btn_SearchByName;
        private DateTimePicker dtp_FilterByEndTime;
        private DateTimePicker dtp_FilterByStartTime;
        private Label lbl_SearchByType;
        private CheckBox chb_Parctical;
        private CheckBox chb_Final;
        private ComboBox cmb_SearchByCourse;
        private Button button1;
        private CustomControls.CustomPanel customPanel1;
        private DataGridView dgv_Exam;
    }
}
