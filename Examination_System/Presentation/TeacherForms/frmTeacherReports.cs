using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation
{
    public partial class frmTeacherReports : Form
    {
        public frmTeacherReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeacherReport1 report1 = new frmTeacherReport1();
            report1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            //new frmTeacherProfile().Show();
        }
    }
}
