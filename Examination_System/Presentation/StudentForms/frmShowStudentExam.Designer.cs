namespace Examination_System.Presentation.StudentForms
{
    partial class frmShowStudentExam
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
            flowLayoutPanelQuestions = new FlowLayoutPanel();
            lb_result = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveAsPdfToolStripMenuItem = new ToolStripMenuItem();
            lb_examtitle = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelQuestions
            // 
            flowLayoutPanelQuestions.AutoScroll = true;
            flowLayoutPanelQuestions.Location = new Point(0, 72);
            flowLayoutPanelQuestions.Name = "flowLayoutPanelQuestions";
            flowLayoutPanelQuestions.Padding = new Padding(20, 0, 0, 0);
            flowLayoutPanelQuestions.Size = new Size(984, 555);
            flowLayoutPanelQuestions.TabIndex = 0;
            // 
            // lb_result
            // 
            lb_result.AutoSize = true;
            lb_result.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_result.Location = new Point(491, 34);
            lb_result.Name = "lb_result";
            lb_result.Size = new Size(65, 25);
            lb_result.TabIndex = 2;
            lb_result.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsPdfToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveAsPdfToolStripMenuItem
            // 
            saveAsPdfToolStripMenuItem.Name = "saveAsPdfToolStripMenuItem";
            saveAsPdfToolStripMenuItem.Size = new Size(133, 22);
            saveAsPdfToolStripMenuItem.Text = "Save as Pdf";
            //saveAsPdfToolStripMenuItem.Click += btnExportPDF_Click;
            // 
            // lb_examtitle
            // 
            lb_examtitle.AutoSize = true;
            lb_examtitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_examtitle.Location = new Point(33, 24);
            lb_examtitle.Name = "lb_examtitle";
            lb_examtitle.Size = new Size(65, 25);
            lb_examtitle.TabIndex = 1;
            lb_examtitle.Text = "label1";
            // 
            // frmShowStudentExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 639);
            Controls.Add(lb_result);
            Controls.Add(menuStrip1);
            Controls.Add(lb_examtitle);
            Controls.Add(flowLayoutPanelQuestions);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 800);
            MinimumSize = new Size(1000, 678);
            Name = "frmShowStudentExam";
            Text = "frmShowStudentExam";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelQuestions;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsPdfToolStripMenuItem;
        private Label lb_examtitle;
        private Label lb_result;
    }
}