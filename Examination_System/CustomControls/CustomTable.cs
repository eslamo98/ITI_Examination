using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.CustomControls
{
    public partial class CustomTable : Form
    {
        public CustomTable()
        {
            InitializeComponent();
        }

        private void CustomTable_Load(object sender, EventArgs e)
        {
            
            
           
            dgv.Rows.Add(new object[] {1, "Eslam", 26});
            dgv.Rows.Add(new object[] {2, "Ahmed", 25});
            dgv.Rows.Add(new object[] {3, "Ali", 22});
        }
    }
}
