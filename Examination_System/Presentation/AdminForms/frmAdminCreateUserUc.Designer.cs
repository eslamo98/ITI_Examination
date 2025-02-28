namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminCreateUserUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCreateUserUc));
            btn_back = new Button();
            label8 = new Label();
            clb_courses = new CheckedListBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_browse = new Button();
            btn_save = new Button();
            tx_lastname = new TextBox();
            com_gender = new ComboBox();
            tx_firstname = new TextBox();
            tx_ssn = new TextBox();
            tx_password = new TextBox();
            tx_email = new TextBox();
            tx_username = new TextBox();
            pic_userImg = new PictureBox();
            lb_title = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_userImg).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(407, 522);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(179, 23);
            btn_back.TabIndex = 50;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(309, 246);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 49;
            label8.Text = "Courses";
            // 
            // clb_courses
            // 
            clb_courses.FormattingEnabled = true;
            clb_courses.Location = new Point(281, 77);
            clb_courses.MaximumSize = new Size(120, 166);
            clb_courses.MinimumSize = new Size(120, 166);
            clb_courses.Name = "clb_courses";
            clb_courses.Size = new Size(120, 166);
            clb_courses.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 472);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 47;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 443);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 46;
            label6.Text = "Lastname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 414);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 45;
            label5.Text = "Firstname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 385);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 44;
            label4.Text = "SSN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 356);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 43;
            label3.Text = "Password";
            label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 327);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 42;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 296);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 41;
            label1.Text = "Username";
            // 
            // btn_browse
            // 
            btn_browse.Location = new Point(407, 259);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(179, 23);
            btn_browse.TabIndex = 40;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(407, 493);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(179, 23);
            btn_save.TabIndex = 39;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // tx_lastname
            // 
            tx_lastname.Location = new Point(407, 435);
            tx_lastname.Name = "tx_lastname";
            tx_lastname.Size = new Size(179, 23);
            tx_lastname.TabIndex = 38;
            // 
            // com_gender
            // 
            com_gender.FormattingEnabled = true;
            com_gender.Location = new Point(407, 464);
            com_gender.Name = "com_gender";
            com_gender.Size = new Size(179, 23);
            com_gender.TabIndex = 37;
            // 
            // tx_firstname
            // 
            tx_firstname.Location = new Point(407, 406);
            tx_firstname.Name = "tx_firstname";
            tx_firstname.Size = new Size(179, 23);
            tx_firstname.TabIndex = 36;
            // 
            // tx_ssn
            // 
            tx_ssn.Location = new Point(407, 377);
            tx_ssn.Name = "tx_ssn";
            tx_ssn.Size = new Size(179, 23);
            tx_ssn.TabIndex = 35;
            // 
            // tx_password
            // 
            tx_password.Location = new Point(407, 348);
            tx_password.Name = "tx_password";
            tx_password.PasswordChar = '*';
            tx_password.Size = new Size(179, 23);
            tx_password.TabIndex = 34;
            // 
            // tx_email
            // 
            tx_email.Location = new Point(407, 319);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(179, 23);
            tx_email.TabIndex = 33;
            // 
            // tx_username
            // 
            tx_username.Location = new Point(407, 288);
            tx_username.Name = "tx_username";
            tx_username.Size = new Size(179, 23);
            tx_username.TabIndex = 32;
            // 
            // pic_userImg
            // 
            pic_userImg.Image = (Image)resources.GetObject("pic_userImg.Image");
            pic_userImg.Location = new Point(407, 77);
            pic_userImg.Name = "pic_userImg";
            pic_userImg.Size = new Size(179, 176);
            pic_userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_userImg.TabIndex = 31;
            pic_userImg.TabStop = false;
            // 
            // lb_title
            // 
            lb_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_title.Location = new Point(281, 18);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(305, 35);
            lb_title.TabIndex = 51;
            lb_title.Text = "label9";
            lb_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAdminCreateUserUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_title);
            Controls.Add(btn_back);
            Controls.Add(label8);
            Controls.Add(clb_courses);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_browse);
            Controls.Add(btn_save);
            Controls.Add(tx_lastname);
            Controls.Add(com_gender);
            Controls.Add(tx_firstname);
            Controls.Add(tx_ssn);
            Controls.Add(tx_password);
            Controls.Add(tx_email);
            Controls.Add(tx_username);
            Controls.Add(pic_userImg);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminCreateUserUc";
            Size = new Size(863, 562);
            ((System.ComponentModel.ISupportInitialize)pic_userImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Label label8;
        private CheckedListBox clb_courses;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_browse;
        private Button btn_save;
        private TextBox tx_lastname;
        private ComboBox com_gender;
        private TextBox tx_firstname;
        private TextBox tx_ssn;
        private TextBox tx_password;
        private TextBox tx_email;
        private TextBox tx_username;
        private PictureBox pic_userImg;
        private Label lb_title;
    }
}
