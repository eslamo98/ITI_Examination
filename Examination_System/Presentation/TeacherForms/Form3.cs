using Examination_System;
using ExaminationSystem.Business.StudentResultService;
using Microsoft.Data.SqlClient;

using System.Data;


namespace ExaminationSystem
{
    public partial class Form3 : Form
    {

        private int _studentId;
        private StudentResultService _studentResultService;

        public Form3(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
            _studentResultService = new StudentResultService();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadStudentResults();
        }

        private void LoadStudentResults()
        {
            dataGridView1.DataSource = _studentResultService.GetStudentResults(_studentId);
            textBox1.Text = $"Result Of Student Number {_studentId}";
        }
    
}
}
