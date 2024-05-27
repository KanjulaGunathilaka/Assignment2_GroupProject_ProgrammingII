using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_GroupProject_ProgrammingII
{
    public partial class CourseForm : Form
    {
        private List<Course> courses;
        private string filePath = @"../../../datafiles/courses.csv";

        public CourseForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            if (File.Exists(filePath))
            {
                courses = File.ReadAllLines(filePath)
                  .Select(line => Course.FromCsv(line))
                  .ToList();
            }
            else
            {
                courses = new List<Course>();
            }
            dataGridViewCourses.DataSource = courses;
            dataGridViewCourses.Columns["ID"].DisplayIndex = 0;
            dataGridViewCourses.Columns["CourseName"].DisplayIndex = 1;
            dataGridViewCourses.Columns["Credits"].DisplayIndex = 2;
            dataGridViewCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var course = new Course
            {
                ID = int.Parse(txtCourseID.Text),
                CourseName = txtCourseName.Text,
                Credits = int.Parse(txtCredits.Text)
            };
            courses.Add(course);
            SaveCourses();
            LoadCourses();
        }

        private void SaveCourses()
        {
            File.WriteAllLines(filePath, courses.Select(c => c.ToCsv()));
        }
    }

}

