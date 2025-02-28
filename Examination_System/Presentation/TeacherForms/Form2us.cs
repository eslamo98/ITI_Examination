using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.Business.StudentService;
using ExaminationSystem;

namespace Examination_System.Presentation.TeacherForms
{
    public partial class Form2us : UserControl
    {
        //int login_id = 12;
        int login_id = General.LoggedUser.ID;

        private StudentService _studentService;
        public Form2us()
        {
            InitializeComponent();
            _studentService = new StudentService();
            LoadCourses();
        }


        private void LoadCourses()
        {
            List<string> courses = _studentService.GetTeacherCourses(login_id);
            foreach (var course in courses)
            {
                checkedListBox1.Items.Add(course);
            }
        }



        private void Form2us_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = _studentService.GetAllStudents(login_id);
            //label1.Text = $"Hello Teacher Number {login_id}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int studentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                Form3us resultForm = new Form3us(studentID);
                //this.Hide();
                //resultForm.Show();
                General.LoadUserControl(resultForm);
            }
            else
            {
                MessageBox.Show("Please choose one Student", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ApplyFilters()
        {
            string name = textBox1.Text.Trim();
            int? gender = null;
            if (rdbtnMale.Checked)
                gender = 0;
            else if (rdbtnFemale.Checked)
                gender = 1;

            List<string> selectedCourses = checkedListBox1.CheckedItems.Cast<string>().ToList();

            dataGridView1.DataSource = _studentService.FilterStudents(login_id, name, gender, selectedCourses);
        }

        // Event handlers call ApplyFilters()
        private void textBox1_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void rdbtnMale_CheckedChanged(object sender, EventArgs e) => ApplyFilters();
        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e) => ApplyFilters();
        private void rdbtnAll_CheckedChanged(object sender, EventArgs e) => ApplyFilters();
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

      

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeUS w = new WelcomeUS();
            General.LoadUserControl(w);

            //new frmTeacherProfile().Show();
        }

    }
}
