using System.Data;

namespace Assignment2_GroupProject_ProgrammingII
{

    public partial class StudentForm : Form
    {
        private List<Student> students;
        private string filePath = @"../../../datafiles/students.csv";

        public StudentForm()
        {
            InitializeComponent();
            LoadStudents();
            dataGridViewStudents.CellClick += dataGridViewStudents_CellClick;
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
            dataGridViewStudents.Columns["ID"].DisplayIndex = 0;
            dataGridViewStudents.Columns["FirstName"].DisplayIndex = 1;
            dataGridViewStudents.Columns["LastName"].DisplayIndex = 2;
            dataGridViewStudents.Columns["DateOfBirth"].DisplayIndex = 3;
            dataGridViewStudents.Columns["Gender"].DisplayIndex = 4;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SaveStudents()
        {
            File.WriteAllLines(filePath, students.Select(s => s.ToCsv()));
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student
                {
                    ID = int.Parse(txtStudentID.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = dateTimePickerDOB.Value,
                    Gender = comboBoxGender.SelectedItem?.ToString()
                };

                if (student.Gender != "Male" && student.Gender != "Female" && student.Gender != "Other")
                {
                    throw new ArgumentException("Gender must be either 'Male', 'Female' or 'Other'.");
                }

                Console.WriteLine("Student to add: " + student.ToCsv());

                students.Add(student);
                SaveStudents();
                LoadStudents();
                Console.WriteLine("Student added successfully.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while adding the student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewStudents.Rows.Count)
            {
                DataGridViewRow row = dataGridViewStudents.Rows[e.RowIndex];

                if (!row.IsNewRow)
                {
                    txtStudentID.Text = row.Cells["ID"].Value.ToString();
                    txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                    txtLastName.Text = row.Cells["LastName"].Value.ToString();
                    dateTimePickerDOB.Value = (DateTime)row.Cells["DateOfBirth"].Value;
                    comboBoxGender.SelectedItem = row.Cells["Gender"].Value.ToString();
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridViewStudents.CurrentCell.RowIndex;
                var selectedStudent = students[selectedIndex];

                // Remove the selected student from the list
                students.Remove(selectedStudent);

                // Save changes to the file
                SaveStudents();
                LoadStudents();
                Console.WriteLine("Student deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while deleting the student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridViewStudents.CurrentCell.RowIndex;
                var selectedStudent = students[selectedIndex];

                // Update the selected student with the new values
                selectedStudent.FirstName = txtFirstName.Text;
                selectedStudent.LastName = txtLastName.Text;
                selectedStudent.DateOfBirth = dateTimePickerDOB.Value;
                selectedStudent.Gender = comboBoxGender.SelectedItem?.ToString();

                if (selectedStudent.Gender != "Male" && selectedStudent.Gender != "Female" && selectedStudent.Gender != "Other")
                {
                    throw new ArgumentException("Gender must be either 'Male', 'Female' or 'Other'.");
                }

                // Save changes to the file
                SaveStudents();
                LoadStudents();
                Console.WriteLine("Student updated successfully.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while updating the student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
