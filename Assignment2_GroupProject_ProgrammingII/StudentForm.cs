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

    public partial class StudentForm : Form
    {
        private List<Student> students;
        private string filePath = @"../../datafiles/students.csv";

        public StudentForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            if (File.Exists(filePath))
            {
                students = File.ReadAllLines(filePath)
                               .Select(line => Student.FromCsv(line))
                               .ToList();
            }
            else
            {
                students = new List<Student>();
            }
            dataGridViewStudents.DataSource = students;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                ID = int.Parse(txtStudentID.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dateTimePickerDOB.Value,
                Gender = comboBoxGender.SelectedItem.ToString()
            };
            students.Add(student);
            SaveStudents();
            LoadStudents();
        }

        private void SaveStudents()
        {
            File.WriteAllLines(filePath, students.Select(s => s.ToCsv()));
        }
    }
}
