//using System;
//using System.Drawing;
//using System.Windows.Forms;

//namespace Examination_System.CustomControls
//{
//    using System;
//    using System.Drawing;
//    using System.Windows.Forms;

//    public class CustomComboBox : UserControl
//    {
//        private ComboBox comboBox;
//        private Label label;
//        private Button button;

//        // Appearance properties
//        public Color BackColor { get; set; } = Color.White;
//        public Color IconColor { get; set; } = Color.Black;
//        public Color DropDownColor { get; set; } = Color.White;
//        public Color BorderColor { get; set; } = Color.Gray;
//        public int BorderSize { get; set; } = 1;

//        public CustomComboBox()
//        {
//            InitializeComponents();
//        }

//        private void InitializeComponents()
//        {
//            comboBox = new ComboBox();
//            label = new Label();
//            button = new Button();

//            // ComboBox settings
//            comboBox.BackColor = DropDownColor;
//            comboBox.DropDownStyle = ComboBoxStyle.DropDown;
//            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

//            // Label settings
//            label.Dock = DockStyle.Fill;
//            label.BackColor = BackColor;
//            label.Click += Label_Click;

//            // Button settings
//            button.Dock = DockStyle.Right;
//            button.Width = 30;
//            button.FlatStyle = FlatStyle.Flat;
//            button.BackColor = BackColor;
//            button.Click += Button_Click;

//            // Add controls
//            Controls.Add(label);
//            Controls.Add(button);
//            Controls.Add(comboBox);
//        }

//        private void Label_Click(object sender, EventArgs e)
//        {
//            comboBox.DroppedDown = true;
//        }

//        private void Button_Click(object sender, EventArgs e)
//        {
//            comboBox.DroppedDown = true;
//        }

//        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            label.Text = comboBox.Text;
//            OnSelectedIndexChanged(EventArgs.Empty);
//        }

//        public event EventHandler SelectedIndexChanged;

//        protected virtual void OnSelectedIndexChanged(EventArgs e)
//        {
//            SelectedIndexChanged?.Invoke(this, e);
//        }

//        protected override void OnPaint(PaintEventArgs e)
//        {
//            base.OnPaint(e);
//            using (Pen pen = new Pen(BorderColor, BorderSize))
//            {
//                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
//            }
//            DrawIcon(e.Graphics);
//        }

//        private void DrawIcon(Graphics g)
//        {
//            // Draw down arrow icon
//            int iconWidth = 10;
//            int iconHeight = 10;
//            int x = button.Right - iconWidth - 5;
//            int y = (Height - iconHeight) / 2;

//            using (Pen pen = new Pen(IconColor))
//            {
//                g.DrawLine(pen, x, y, x + iconWidth / 2, y + iconHeight);
//                g.DrawLine(pen, x + iconWidth / 2, y + iconHeight, x + iconWidth, y);
//            }
//        }

//        // Properties for data binding
//        public object DataSource
//        {
//            get => comboBox.DataSource;
//            set => comboBox.DataSource = value;
//        }

//        public void AddItem(object item)
//        {
//            comboBox.Items.Add(item);
//        }

//        public void ClearItems()
//        {
//            comboBox.Items.Clear();
//        }

//        public int SelectedIndex
//        {
//            get => comboBox.SelectedIndex;
//            set => comboBox.SelectedIndex = value;
//        }

//        public string Text
//        {
//            get => label.Text;
//            set => label.Text = value;
//        }
//    }
//}