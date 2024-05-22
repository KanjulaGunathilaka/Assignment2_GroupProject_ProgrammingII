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
    public partial class TeacherForm : Form
    {
        private List<Teacher> teachers;
        private string filePath = @"../../datafiles/teachers.csv";

        public TeacherForm()
        {
            InitializeComponent();
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            if (File.Exists(filePath))
            {
                teachers = File.ReadAllLines(filePath)
                               .Select(line => Teacher.FromCsv(line))
                               .ToList();
            }
            else
            {
                teachers = new List<Teacher>();
            }
            dataGridViewTeachers.DataSource = teachers;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher
            {
                ID = int.Parse(txtTeacherID.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Subject = txtSubject.Text
            };
            teachers.Add(teacher);
            SaveTeachers();
            LoadTeachers();
        }

        private void SaveTeachers()
        {
            File.WriteAllLines(filePath, teachers.Select(t => t.ToCsv()));
        }
    }
}
