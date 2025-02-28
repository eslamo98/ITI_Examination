namespace Examination_System.Presentation.AdminForms
{
    partial class frmShowStudentExamUc
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
            lb_result = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveAsPdfToolStripMenuItem = new ToolStripMenuItem();
            lb_examtitle = new Label();
            flowLayoutPanelQuestions = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_result
            // 
            lb_result.AutoSize = true;
            lb_result.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_result.Location = new Point(499, 27);
            lb_result.Name = "lb_result";
            lb_result.Size = new Size(65, 25);
            lb_result.TabIndex = 5;
            lb_result.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(863, 24);
            menuStrip1.TabIndex = 3;
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
            // 
            // lb_examtitle
            // 
            lb_examtitle.AutoSize = true;
            lb_examtitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_examtitle.Location = new Point(40, 27);
            lb_examtitle.Name = "lb_examtitle";
            lb_examtitle.Size = new Size(65, 25);
            lb_examtitle.TabIndex = 4;
            lb_examtitle.Text = "label1";
            // 
            // flowLayoutPanelQuestions
            // 
            flowLayoutPanelQuestions.AutoScroll = true;
            flowLayoutPanelQuestions.Location = new Point(3, 79);
            flowLayoutPanelQuestions.Name = "flowLayoutPanelQuestions";
            flowLayoutPanelQuestions.Padding = new Padding(20, 0, 0, 0);
            flowLayoutPanelQuestions.Size = new Size(857, 480);
            flowLayoutPanelQuestions.TabIndex = 6;
            // 
            // frmShowStudentExamUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelQuestions);
            Controls.Add(lb_result);
            Controls.Add(menuStrip1);
            Controls.Add(lb_examtitle);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmShowStudentExamUc";
            Size = new Size(863, 562);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_result;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsPdfToolStripMenuItem;
        private Label lb_examtitle;
        private FlowLayoutPanel flowLayoutPanelQuestions;
    }
}
