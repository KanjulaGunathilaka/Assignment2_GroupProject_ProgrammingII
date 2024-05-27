using System.Data;

namespace Assignment2_GroupProject_ProgrammingII
{
    public partial class TeacherForm : Form
    {
        private List<Teacher> teachers;
        private string filePath = @"../../../datafiles/teachers.csv";

        public TeacherForm()
        {
            InitializeComponent();
            LoadTeachers();
            dataGridViewTeachers.CellClick += dataGridViewTeachers_CellClick;
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
            dataGridViewTeachers.Columns["ID"].DisplayIndex = 0;
            dataGridViewTeachers.Columns["FirstName"].DisplayIndex = 1;
            dataGridViewTeachers.Columns["LastName"].DisplayIndex = 2;
            dataGridViewTeachers.Columns["Subject"].DisplayIndex = 3;
            dataGridViewTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SaveTeachers()
        {
            File.WriteAllLines(filePath, teachers.Select(t => t.ToCsv()));
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
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
                MessageBox.Show("Teacher added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while adding the teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTeachers.Rows.Count)
            {
                DataGridViewRow row = dataGridViewTeachers.Rows[e.RowIndex];

                if (!row.IsNewRow)
                {
                    txtTeacherID.Text = row.Cells["ID"].Value.ToString();
                    txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                    txtLastName.Text = row.Cells["LastName"].Value.ToString();
                    txtSubject.Text = row.Cells["Subject"].Value.ToString();
                }
            }
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridViewTeachers.CurrentCell.RowIndex;
                var selectedTeacher = teachers[selectedIndex];

                selectedTeacher.FirstName = txtFirstName.Text;
                selectedTeacher.LastName = txtLastName.Text;
                selectedTeacher.Subject = txtSubject.Text;

                SaveTeachers();
                LoadTeachers();
                MessageBox.Show("Teacher updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while updating the teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridViewTeachers.CurrentCell.RowIndex;
                var selectedTeacher = teachers[selectedIndex];

                teachers.Remove(selectedTeacher);

                SaveTeachers();
                LoadTeachers();
                MessageBox.Show("Teacher deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while deleting the teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
