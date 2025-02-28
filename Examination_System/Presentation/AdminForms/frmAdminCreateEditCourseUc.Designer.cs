namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminCreateEditCourseUc
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
            customPanel1 = new CustomControls.CustomPanel();
            btn_back = new Button();
            btn_save = new Button();
            panel1 = new Panel();
            label4 = new Label();
            n_courseduration = new NumericUpDown();
            label3 = new Label();
            com_courseteacher = new ComboBox();
            n_coursegrade = new NumericUpDown();
            label2 = new Label();
            tx_coursename = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lb_title = new Label();
            customPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)n_courseduration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_coursegrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(btn_back);
            customPanel1.Controls.Add(btn_save);
            customPanel1.Controls.Add(panel1);
            customPanel1.Controls.Add(pictureBox1);
            customPanel1.ForeColor = Color.White;
            customPanel1.GradientBottomColor = Color.FromArgb(179, 157, 219);
            customPanel1.GradientTopColor = Color.FromArgb(106, 13, 173);
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(120, 86);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(644, 413);
            customPanel1.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Black;
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(326, 341);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(271, 40);
            btn_back.TabIndex = 3;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click_1;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Black;
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(37, 341);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(271, 40);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(n_courseduration);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(com_courseteacher);
            panel1.Controls.Add(n_coursegrade);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tx_coursename);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 259);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 212);
            label4.Name = "label4";
            label4.Size = new Size(103, 17);
            label4.TabIndex = 7;
            label4.Text = "Course Duration";
            // 
            // n_courseduration
            // 
            n_courseduration.Location = new Point(124, 212);
            n_courseduration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            n_courseduration.Name = "n_courseduration";
            n_courseduration.Size = new Size(147, 23);
            n_courseduration.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 165);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 5;
            label3.Text = "Course Grade";
            // 
            // com_courseteacher
            // 
            com_courseteacher.FormattingEnabled = true;
            com_courseteacher.Location = new Point(124, 106);
            com_courseteacher.Name = "com_courseteacher";
            com_courseteacher.Size = new Size(147, 23);
            com_courseteacher.TabIndex = 4;
            // 
            // n_coursegrade
            // 
            n_coursegrade.Location = new Point(124, 165);
            n_coursegrade.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            n_coursegrade.Name = "n_coursegrade";
            n_coursegrade.Size = new Size(147, 23);
            n_coursegrade.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 106);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 2;
            label2.Text = "Course Teacher";
            // 
            // tx_coursename
            // 
            tx_coursename.Location = new Point(124, 51);
            tx_coursename.Name = "tx_coursename";
            tx_coursename.Size = new Size(147, 23);
            tx_coursename.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 53);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 0;
            label1.Text = "Course Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.online_education;
            pictureBox1.Location = new Point(325, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_title
            // 
            lb_title.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_title.Location = new Point(120, 20);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(644, 40);
            lb_title.TabIndex = 1;
            lb_title.Text = "Create a new Course";
            lb_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAdminCreateEditCourseUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_title);
            Controls.Add(customPanel1);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminCreateEditCourseUc";
            Size = new Size(863, 562);
            customPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)n_courseduration).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_coursegrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPanel customPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ComboBox com_courseteacher;
        private NumericUpDown n_coursegrade;
        private Label label2;
        private TextBox tx_coursename;
        private Label label1;
        private Button btn_save;
        private Label label4;
        private NumericUpDown n_courseduration;
        private Label label3;
        private Label lb_title;
        private Button btn_back;
    }
}
