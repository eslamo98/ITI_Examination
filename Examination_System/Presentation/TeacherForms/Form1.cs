using Examination_System.Presentation;
using ExaminationSystem.Business.ExamService;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ExaminationSystem
{
    public partial class Form1 : Form
    {
      
            int login_id = 11;
            int gendervalue;
          ExamService _examService;

            public Form1()
            {
                InitializeComponent();
                _examService = new ExamService();

            }
            //load courses of the teacher in the checkedlistbox
            private void Form1_Load(object sender, EventArgs e)
            {
                dateTimePicker1.ShowCheckBox = true;
                dateTimePicker1.Checked = false;

                dateTimePicker2.ShowCheckBox = true;
                dateTimePicker2.Checked = false;
                checkedListBox3.Items.Add("All");
                LoadCourses();
                Title.Text = $"Hello Teacher Number {login_id}";
            }
            private void LoadCourses()
            {
                DataTable courses = _examService.GetCoursesByTeacher(login_id);
                foreach (DataRow row in courses.Rows)
                {
                    checkedListBox3.Items.Add(row["CourseName"].ToString());
                }
            }

            private void ApplyFilters()
            {
                // Get selected date range (make it nullable)
                DateTime? startDate = dateTimePicker1.Checked ? dateTimePicker1.Value : (DateTime?)null;
                DateTime? endDate = dateTimePicker2.Checked ? dateTimePicker2.Value : (DateTime?)null;

                // Get selected statuses
                List<int> statusList = checkedListBox1.CheckedItems.Cast<string>().Select(item => item switch
                {
                    "Pending" => 0,
                    "Started" => 1,
                    "Finished" => 2,
                    _ => -1
                }).Where(x => x != -1).ToList();

                // Get selected exam types
                List<int> typeList = checkedListBox2.CheckedItems.Cast<string>().Select(item => item switch
                {
                    "Practice" => 0,
                    "Final" => 1,
                    _ => -1
                }).Where(x => x != -1).ToList();

                // Get selected courses
                List<string> selectedCourses = checkedListBox3.CheckedItems.Cast<string>().ToList();
                if (selectedCourses.Contains("All"))
                {
                    selectedCourses = new List<string>();
                }

                // Call the service to filter exams
                DataTable table = _examService.FilterExams(
                    login_id,
                    startDate,  // Null 
                    endDate,
                    statusList.Count > 0 ? statusList : null,
                    typeList.Count > 0 ? typeList : null,
                    selectedCourses.Count > 0 ? selectedCourses : null
                );


                dataGridView1.DataSource = table;
            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e) => ApplyFilters();
            private void dateTimePicker2_ValueChanged(object sender, EventArgs e) => ApplyFilters();
            private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
            private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
            private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    }
