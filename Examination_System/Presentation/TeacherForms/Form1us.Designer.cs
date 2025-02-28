namespace Examination_System.Presentation.TeacherForms
{
    partial class Form1us
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
            btn_back = new Button();
            label3 = new Label();
            Title = new Label();
            checkedListBox3 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button6 = new Button();
            customPanel1 = new Examination_System.CustomControls.CustomPanel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(-90, 32);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(86, 31);
            btn_back.TabIndex = 45;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;

            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 100);

            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(85, 6);

            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 44;
            label3.Text = "Date Of Exams ";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Goudy Stout", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(236, 20);
            Title.Name = "Title";
            Title.Size = new Size(408, 39);
            Title.TabIndex = 43;
            Title.Text = "Exam Report";
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;

            checkedListBox3.Location = new Point(719, 197);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(180, 70);

            checkedListBox3.Location = new Point(278, 42);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(180, 48);

            checkedListBox3.TabIndex = 42;
            checkedListBox3.SelectedIndexChanged += checkedListBox3_SelectedIndexChanged;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Practice", "Final" });
            checkedListBox2.Location = new Point(229, 13);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(95, 48);
            checkedListBox2.TabIndex = 41;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Pending", "Started", "Finished" });
            checkedListBox1.Location = new Point(202, 13);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(111, 48);
            checkedListBox1.TabIndex = 40;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.Location = new Point(6, 13);
            label7.Name = "label7";
            label7.Size = new Size(180, 25);
            label7.TabIndex = 39;
            label7.Text = "Status Of Exams ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(3, 22);
            label6.Name = "label6";
            label6.Size = new Size(162, 25);
            label6.TabIndex = 38;
            label6.Text = "Type of Exams ";
            // 
            // label5
            // 
            label5.AutoSize = true;

            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(646, 149);

            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(0, 42);

            label5.Name = "label5";
            label5.Size = new Size(260, 25);
            label5.TabIndex = 37;
            label5.Text = "coures which have exams";
            // 
            // label2
            // 
            label2.AutoSize = true;

            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(29, 183);

            label2.Font = new Font("Perpetua", 12F);
            label2.Location = new Point(6, 77);

            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 36;
            label2.Text = "end date :";
            // 
            // label1
            // 
            label1.AutoSize = true;

            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(29, 145);

            label1.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 46);

            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 35;
            label1.Text = "start date :";
            // 
            // dateTimePicker2
            // 

            dateTimePicker2.Location = new Point(165, 187);

            dateTimePicker2.Location = new Point(94, 77);

            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(268, 27);
            dateTimePicker2.TabIndex = 34;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 

            dateTimePicker1.Location = new Point(165, 149);

            dateTimePicker1.Location = new Point(94, 44);

            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(268, 27);
            dateTimePicker1.TabIndex = 33;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 

            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-214, 321);
            dataGridView1.MaximumSize = new Size(1200, 400);
            dataGridView1.MinimumSize = new Size(1200, 400);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1200, 400);
            dataGridView1.TabIndex = 32;
            // 

            // button6
            // 
            button6.BackColor = Color.FromArgb(35, 40, 45);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(391, 681);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(147, 43);
            button6.TabIndex = 31;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
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
            customPanel1.Location = new Point(31, 345);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 13);
            customPanel1.Size = new Size(921, 328);
            customPanel1.TabIndex = 46;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(921, 315);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(31, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 125);
            panel1.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(checkedListBox1);
            panel2.Location = new Point(31, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 74);
            panel2.TabIndex = 48;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(checkedListBox3);
            panel3.Location = new Point(477, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(475, 125);
            panel3.TabIndex = 49;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(checkedListBox2);
            panel4.Location = new Point(477, 253);
            panel4.Name = "panel4";
            panel4.Size = new Size(475, 74);
            panel4.TabIndex = 50;
            // 
            // Form1us
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(customPanel1);
            Controls.Add(btn_back);
            Controls.Add(Title);
            Controls.Add(button6);
            MaximumSize = new Size(986, 749);
            MinimumSize = new Size(986, 749);
            Name = "Form1us";
            Size = new Size(986, 749);
            Load += Form1us_Load;
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Label label3;
        private Label Title;
        private CheckedListBox checkedListBox3;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button6;
        private CustomControls.CustomPanel customPanel1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
