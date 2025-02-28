using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Examination_System.CustomControls
{
    public class CustomButton : Button
    {
        private int _borderRadius = 20;
        private Color _borderColor = Color.Black;
        private int _borderSize = 2;
        private Color _shadowColor = Color.Gray;
        private int _shadowSize = 5;
        private Color _defaultBackColor;
        private Color _hoverBackColor;
        private Color _clickBackColor;

        public CustomButton()
        {
            // Default colors
            _defaultBackColor = Color.MediumSlateBlue;
            _hoverBackColor = ControlPaint.Light(_defaultBackColor, 0.2f);  // Lighter on hover
            _clickBackColor = ControlPaint.Dark(_defaultBackColor, 0.2f);   // Darker on click

            this.BackColor = _defaultBackColor;
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(100, 40);

            // Event Handlers
            this.MouseEnter += CustomButton_MouseEnter;
            this.MouseLeave += CustomButton_MouseLeave;
            this.MouseDown += CustomButton_MouseDown;
            this.MouseUp += CustomButton_MouseUp;
        }

        private void CustomButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = _hoverBackColor;
            this.Cursor = Cursors.Hand; // Change cursor to pointer
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = _defaultBackColor;
            this.Cursor = Cursors.Default; // Reset cursor
        }

        private void CustomButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = _clickBackColor;
        }

        private void CustomButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = _hoverBackColor; // Restore hover color after click
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Create rounded path
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            GraphicsPath roundedPath = GetRoundedPath(rect, _borderRadius);

            // Clip the button's region to the rounded shape
            this.Region = new Region(roundedPath);

            // Draw Background
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                g.FillPath(brush, roundedPath);
            }

            // Draw Border
            if (_borderSize > 0)
            {
                using (Pen pen = new Pen(_borderColor, _borderSize))
                {
                    g.DrawPath(pen, roundedPath);
                }
            }

            // Draw Text
            TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            // Ensure radius is not too large
            if (radius > rect.Height / 2) radius = rect.Height / 2;
            if (radius > rect.Width / 2) radius = rect.Width / 2;

            // Define the rounded corners
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left
            path.CloseFigure();

            return path;
        }
    }
}
