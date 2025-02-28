namespace Examination_System.Presentation.TeacherForms
{
    partial class Form2us
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            btn_back = new Button();
            label4 = new Label();
            checkedListBox1 = new CheckedListBox();
            rdbtnAll = new RadioButton();
            rdbtnFemale = new RadioButton();
            rdbtnMale = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            customPanel1 = new Examination_System.CustomControls.CustomPanel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button6 = new Button();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(-84, 83);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(86, 31);
            btn_back.TabIndex = 29;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(16, 27);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 28;
            label4.Text = "Coures";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(156, 11);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 70);
            checkedListBox1.TabIndex = 27;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // rdbtnAll
            // 
            rdbtnAll.AutoSize = true;
            rdbtnAll.Location = new Point(218, 7);
            rdbtnAll.Name = "rdbtnAll";
            rdbtnAll.Size = new Size(48, 24);
            rdbtnAll.TabIndex = 26;
            rdbtnAll.TabStop = true;
            rdbtnAll.Text = "All";
            rdbtnAll.UseVisualStyleBackColor = true;
            rdbtnAll.CheckedChanged += rdbtnAll_CheckedChanged;
            // 
            // rdbtnFemale
            // 
            rdbtnFemale.AutoSize = true;
            rdbtnFemale.Location = new Point(218, 67);
            rdbtnFemale.Name = "rdbtnFemale";
            rdbtnFemale.Size = new Size(78, 24);
            rdbtnFemale.TabIndex = 25;
            rdbtnFemale.TabStop = true;
            rdbtnFemale.Text = "Female";
            rdbtnFemale.UseVisualStyleBackColor = true;
            rdbtnFemale.CheckedChanged += rdbtnFemale_CheckedChanged;
            // 
            // rdbtnMale
            // 
            rdbtnMale.AutoSize = true;
            rdbtnMale.Location = new Point(218, 37);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Size = new Size(63, 24);
            rdbtnMale.TabIndex = 24;
            rdbtnMale.TabStop = true;
            rdbtnMale.Text = "Male";
            rdbtnMale.UseVisualStyleBackColor = true;
            rdbtnMale.CheckedChanged += rdbtnMale_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(3, 35);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 23;
            label3.Text = "Student Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 22;
            label2.Text = "Student Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 40, 45);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(587, 673);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(193, 54);
            button1.TabIndex = 19;
            button1.Text = "Student Result";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 16.2F, FontStyle.Bold);
            label1.Location = new Point(191, 23);
            label1.Name = "label1";
            label1.Size = new Size(494, 39);
            label1.TabIndex = 18;
            label1.Text = "Student Report";
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dataGridView1);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(31, 334);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 13);
            customPanel1.Size = new Size(907, 331);
            customPanel1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.Black;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle13.Padding = new Padding(15);
            dataGridViewCellStyle13.SelectionBackColor = Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(907, 318);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(31, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 106);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rdbtnAll);
            panel2.Controls.Add(rdbtnMale);
            panel2.Controls.Add(rdbtnFemale);
            panel2.Location = new Point(466, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 106);
            panel2.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(checkedListBox1);
            panel3.Location = new Point(31, 220);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 89);
            panel3.TabIndex = 33;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(35, 40, 45);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(173, 673);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(177, 54);
            button6.TabIndex = 32;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form2us
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(customPanel1);
            Controls.Add(btn_back);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximumSize = new Size(986, 749);
            MinimumSize = new Size(986, 749);
            Name = "Form2us";
            Size = new Size(986, 749);
            Load += Form2us_Load;
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private RadioButton rdbtnAll;
        private RadioButton rdbtnFemale;
        private RadioButton rdbtnMale;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private CustomControls.CustomPanel customPanel1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button6;
    }
}
