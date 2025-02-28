using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using ExaminationSystem.Business.StudentResultService;

namespace Examination_System.Presentation.TeacherForms
{
    public partial class Form3us : UserControl
    {

        private int _studentId;
        private StudentResultService _studentResultService;

        public Form3us(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
            _studentResultService = new StudentResultService();
        }

        private void Form3us_Load(object sender, EventArgs e)
        {
            LoadStudentResults();
        }

        private void LoadStudentResults()
        {
            dataGridView1.DataSource = _studentResultService.GetStudentResults(_studentId);
            textBox1.Text = $"Result Of Student Number {_studentId}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2us form2us = new Form2us();
            General.LoadUserControl(form2us);

        }
    }
}
