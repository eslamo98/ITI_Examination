namespace Examination_System.Presentation.StudentForms
{
    partial class frmExam
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
            lblTime = new Krypton.Toolkit.KryptonLabel();
            panelQuestions = new Krypton.Toolkit.KryptonPanel();
            btnSubmit = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)panelQuestions).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Location = new Point(489, 6);
            lblTime.Margin = new Padding(2, 2, 2, 2);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(50, 20);
            lblTime.TabIndex = 0;
            lblTime.Values.Text = "lblTime";
            // 
            // panelQuestions
            // 
            panelQuestions.Location = new Point(65, 42);
            panelQuestions.Margin = new Padding(2, 2, 2, 2);
            panelQuestions.Name = "panelQuestions";
            panelQuestions.Size = new Size(691, 266);
            panelQuestions.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(734, 16);
            btnSubmit.Margin = new Padding(2, 2, 2, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 22);
            btnSubmit.TabIndex = 2;
            btnSubmit.Values.DropDownArrowColor = Color.Empty;
            btnSubmit.Values.Text = "Submit";
            // 
            // frmExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 318);
            Controls.Add(btnSubmit);
            Controls.Add(panelQuestions);
            Controls.Add(lblTime);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmExam";
            Text = "frmExam";
            ((System.ComponentModel.ISupportInitialize)panelQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTime;
        private Krypton.Toolkit.KryptonPanel panelQuestions;
        private Krypton.Toolkit.KryptonButton btnSubmit;
    }
}