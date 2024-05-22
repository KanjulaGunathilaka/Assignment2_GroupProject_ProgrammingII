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
    public partial class EnrollmentForm : Form
    {
        private List<Enrollment> enrollments;
        private List<Student> students;
        private List<Course> courses;
        private string enrollmentsFilePath = @"../../datafiles/enrollments.csv";
        private string studentsFilePath = @"../../datafiles/students.csv";
        private string coursesFilePath = @"../../datafiles/courses.csv";

        public event EventHandler EnrollmentAdded;

        public EnrollmentForm()
        {
            InitializeComponent();
            LoadEnrollmentsAsync();
            LoadStudents();
            LoadCourses();
        }

        private async Task LoadEnrollmentsAsync()
        {
            await Task.Run(() => LoadEnrollments());
        }

        private void LoadEnrollments()
        {
            if (File.Exists(enrollmentsFilePath))
            {
                enrollments = File.ReadAllLines(enrollmentsFilePath)
                                  .Select(line => Enrollment.FromCsv(line))
                                  .ToList();
            }
            else
            {
                enrollments = new List<Enrollment>();
            }
            Invoke(new Action(() => dataGridViewEnrollments.DataSource = enrollments));
        }

        private void LoadStudents()
        {
            if (File.Exists(studentsFilePath))
            {
                students = File.ReadAllLines(studentsFilePath)
                               .Select(line => Student.FromCsv(line))
                               .ToList();
            }
            else
            {
                students = new List<Student>();
            }
            comboBoxStudents.DataSource = students;
            comboBoxStudents.DisplayMember = "FullName";
            comboBoxStudents.ValueMember = "ID";
        }

        private void LoadCourses()
        {
            if (File.Exists(coursesFilePath))
            {
                courses = File.ReadAllLines(coursesFilePath)
                              .Select(line => Course.FromCsv(line))
                              .ToList();
            }
            else
            {
                courses = new List<Course>();
            }
            comboBoxCourses.DataSource = courses;
            comboBoxCourses.DisplayMember = "CourseName";
            comboBoxCourses.ValueMember = "ID";
        }

        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            var enrollment = new Enrollment
            {
                ID = int.Parse(txtEnrollmentID.Text),
                StudentID = (int)comboBoxStudents.SelectedValue,
                CourseID = (int)comboBoxCourses.SelectedValue,
                EnrollmentDate = dateTimePickerEnrollmentDate.Value
            };
            enrollments.Add(enrollment);
            SaveEnrollments();
            LoadEnrollmentsAsync();
            OnEnrollmentAdded(EventArgs.Empty);
        }

        protected virtual void OnEnrollmentAdded(EventArgs e)
        {
            EnrollmentAdded?.Invoke(this, e);
        }

        private void SaveEnrollments()
        {
            File.WriteAllLines(enrollmentsFilePath, enrollments.Select(e => e.ToCsv()));
        }
    }
}

