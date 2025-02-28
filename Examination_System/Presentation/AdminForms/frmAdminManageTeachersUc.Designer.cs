namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminManageTeachersUc
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
            dgv_Teacher = new DataGridView();
            txb_SearchByName = new TextBox();
            lbl_search_name = new Label();
            txb_search_Id = new TextBox();
            lbl_Search_Id = new Label();
            btn_report = new Button();
            btnNew = new Button();
            cmb_Cources = new ComboBox();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgv_Teacher);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(23, 117);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(813, 422);
            customPanel1.TabIndex = 17;
            // 
            // dgv_Teacher
            // 
            dgv_Teacher.AllowUserToAddRows = false;
            dgv_Teacher.AllowUserToDeleteRows = false;
            dgv_Teacher.AllowUserToResizeColumns = false;
            dgv_Teacher.AllowUserToResizeRows = false;
            dgv_Teacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_Teacher.BackgroundColor = Color.White;
            dgv_Teacher.BorderStyle = BorderStyle.None;
            dgv_Teacher.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Teacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Teacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Teacher.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Teacher.Dock = DockStyle.Fill;
            dgv_Teacher.EnableHeadersVisualStyles = false;
            dgv_Teacher.Location = new Point(0, 0);
            dgv_Teacher.Name = "dgv_Teacher";
            dgv_Teacher.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Teacher.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Teacher.RowHeadersVisible = false;
            dgv_Teacher.RowHeadersWidth = 25;
            dgv_Teacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Teacher.Size = new Size(813, 412);
            dgv_Teacher.TabIndex = 0;
            dgv_Teacher.CellClick += HandleEDD_Buttons_Click;
            // 
            // txb_SearchByName
            // 
            txb_SearchByName.Location = new Point(231, 20);
            txb_SearchByName.Margin = new Padding(2);
            txb_SearchByName.Multiline = true;
            txb_SearchByName.Name = "txb_SearchByName";
            txb_SearchByName.Size = new Size(190, 34);
            txb_SearchByName.TabIndex = 45;
            txb_SearchByName.TextChanged += txb_SearchByName_TextChanged;
            txb_SearchByName.KeyPress += txb_SearchByName_KeyPress;
            txb_SearchByName.KeyUp += SearchByName;
            // 
            // lbl_search_name
            // 
            lbl_search_name.BackColor = Color.White;
            lbl_search_name.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_search_name.ForeColor = Color.Brown;
            lbl_search_name.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_search_name.Location = new Point(24, 20);
            lbl_search_name.Margin = new Padding(2, 0, 2, 0);
            lbl_search_name.Name = "lbl_search_name";
            lbl_search_name.Size = new Size(203, 32);
            lbl_search_name.TabIndex = 44;
            lbl_search_name.Text = "Search By Name";
            lbl_search_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txb_search_Id
            // 
            txb_search_Id.Location = new Point(231, 65);
            txb_search_Id.Margin = new Padding(2);
            txb_search_Id.Multiline = true;
            txb_search_Id.Name = "txb_search_Id";
            txb_search_Id.Size = new Size(190, 34);
            txb_search_Id.TabIndex = 43;
            txb_search_Id.TextChanged += txb_search_Id_TextChanged;
            txb_search_Id.KeyPress += txb_search_Id_KeyPress;
            txb_search_Id.KeyUp += SearchById;
            // 
            // lbl_Search_Id
            // 
            lbl_Search_Id.BackColor = Color.White;
            lbl_Search_Id.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Search_Id.ForeColor = Color.Brown;
            lbl_Search_Id.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_Search_Id.Location = new Point(24, 65);
            lbl_Search_Id.Margin = new Padding(2, 0, 2, 0);
            lbl_Search_Id.Name = "lbl_Search_Id";
            lbl_Search_Id.Size = new Size(203, 32);
            lbl_Search_Id.TabIndex = 42;
            lbl_Search_Id.Text = "Search By ID";
            lbl_Search_Id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_report
            // 
            btn_report.BackColor = Color.White;
            btn_report.Cursor = Cursors.Hand;
            btn_report.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_report.ForeColor = Color.Brown;
            btn_report.Location = new Point(638, 21);
            btn_report.Margin = new Padding(2);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(199, 37);
            btn_report.TabIndex = 41;
            btn_report.Text = "Report";
            btn_report.UseVisualStyleBackColor = false;
            btn_report.Click += btn_report_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.ControlLightLight;
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Popup;
            btnNew.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Brown;
            btnNew.Location = new Point(426, 21);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(207, 36);
            btnNew.TabIndex = 6;
            btnNew.Text = "New Teacher";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btn_new_teacher_Click;
            // 
            // cmb_Cources
            // 
            cmb_Cources.FormattingEnabled = true;
            cmb_Cources.Location = new Point(426, 76);
            cmb_Cources.Name = "cmb_Cources";
            cmb_Cources.Size = new Size(207, 23);
            cmb_Cources.TabIndex = 46;
            cmb_Cources.SelectedIndexChanged += cmb_Cources_SelectedIndexChanged;
            // 
            // frmAdminManageTeachersUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmb_Cources);
            Controls.Add(btn_report);
            Controls.Add(txb_SearchByName);
            Controls.Add(lbl_search_name);
            Controls.Add(customPanel1);
            Controls.Add(lbl_Search_Id);
            Controls.Add(txb_search_Id);
            Controls.Add(btnNew);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminManageTeachersUc";
            Size = new Size(863, 562);
            Load += frmAdminManageTeachers_Load;
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel customPanel1;
        private DataGridView dgv_Teacher;
        private TextBox txb_SearchByName;
        private Label lbl_search_name;
        private TextBox txb_search_Id;
        private Label lbl_Search_Id;
        private Button btn_report;
        private Button btnNew;
        private ComboBox cmb_Cources;
    }
}
