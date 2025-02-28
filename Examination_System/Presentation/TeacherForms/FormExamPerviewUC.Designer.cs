namespace Examination_System.Presentation.TeacherForms
{
    partial class FormExamPerviewUC
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
            flowPanelQuestions = new FlowLayoutPanel();
            flowPanelExamInfo = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowPanelQuestions
            // 
            flowPanelQuestions.AutoScroll = true;
            flowPanelQuestions.AutoSize = true;
            flowPanelQuestions.Dock = DockStyle.Fill;
            flowPanelQuestions.FlowDirection = FlowDirection.TopDown;
            flowPanelQuestions.Location = new Point(0, 20);
            flowPanelQuestions.Name = "flowPanelQuestions";
            flowPanelQuestions.Size = new Size(1353, 688);
            flowPanelQuestions.TabIndex = 7;
            flowPanelQuestions.WrapContents = false;
            // 
            // flowPanelExamInfo
            // 
            flowPanelExamInfo.AutoSize = true;
            flowPanelExamInfo.Dock = DockStyle.Top;
            flowPanelExamInfo.FlowDirection = FlowDirection.TopDown;
            flowPanelExamInfo.Location = new Point(0, 0);
            flowPanelExamInfo.Name = "flowPanelExamInfo";
            flowPanelExamInfo.Padding = new Padding(10);
            flowPanelExamInfo.Size = new Size(1353, 20);
            flowPanelExamInfo.TabIndex = 6;
            // 
            // FormExamPerviewUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowPanelQuestions);
            Controls.Add(flowPanelExamInfo);
            Name = "FormExamPerviewUC";
            Size = new Size(1353, 708);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanelQuestions;
        private FlowLayoutPanel flowPanelExamInfo;
    }
}
