using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.CustomControls
{
    public class CustomPanel:Panel
    {
        #region Fields
        private int borderRadius = 30;
        private float grediantAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;
        #endregion

        #region Constructor
        public CustomPanel()
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.Black;
            this.Size = new Size(150, 150);

        }

        #endregion

        #region Properties
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the border radius of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                Invalidate(); // Refresh control
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the angle of the gradient.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public float GrediantAngle
        {
            get => grediantAngle;
            set
            {
                grediantAngle = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the top gradient color.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set
            {
                gradientTopColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the bottom gradient color.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set
            {
                gradientBottomColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Methods
        private GraphicsPath GetPath(RectangleF rec, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rec.Width - radius, rec.Height - radius, radius, radius, 0, 90);
            path.AddArc(rec.X, rec.Height - radius, radius, radius, 90, 90);
            path.AddArc(rec.X, rec.Y, radius, radius, 180, 90);
            path.AddArc(rec.Width - radius, rec.Y, radius, radius, 270, 90);
            path.CloseFigure();

            return path;
        }
        #endregion

        #region Override Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBottomColor, this.grediantAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, this.ClientRectangle);

            //borders

            RectangleF rec = new RectangleF(0, 0, this.Width, this.Height);
            if(this.borderRadius > 2)
            {
                using (GraphicsPath path = GetPath(rec, this.borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
                
                
            } else this.Region = new Region(rec);

        }
        #endregion
    }
}
