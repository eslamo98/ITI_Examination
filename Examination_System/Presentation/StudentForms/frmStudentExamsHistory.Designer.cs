namespace Examination_System.Presentation
{
    partial class frmStudentExamsHistory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBack = new Button();
            buttonRefresh = new Button();
            dgvExamsHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvExamsHistory).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(30, 30);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 40);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += button1_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(150, 30);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(120, 40);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += frmStudentExamsHistory_Load_1;
            // 
            // dgvExamsHistory
            // 
            dgvExamsHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamsHistory.Location = new Point(30, 100);
            dgvExamsHistory.Name = "dgvExamsHistory";
            dgvExamsHistory.RowHeadersWidth = 72;
            dgvExamsHistory.Size = new Size(1200, 500);
            dgvExamsHistory.TabIndex = 2;
            dgvExamsHistory.CellClick += dgvExamsHistory_CellClick;
            // 
            // frmStudentExamsHistory
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 650);
            Controls.Add(dgvExamsHistory);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonBack);
            Name = "frmStudentExamsHistory";
            Text = "Student Exams History";
            Load += frmStudentExamsHistory_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvExamsHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private Button buttonRefresh;
        private DataGridView dgvExamsHistory;
    }
}
