using System.Data;

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
            dataGridViewCourses.CellClick += dataGridViewCourses_CellClick;
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

        private void SaveCourses()
        {
            File.WriteAllLines(filePath, courses.Select(c => c.ToCsv()));
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
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
                MessageBox.Show("Course added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while adding the course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewCourses.Rows.Count)
            {
                DataGridViewRow row = dataGridViewCourses.Rows[e.RowIndex];

                if (!row.IsNewRow)
                {
                    txtCourseID.Text = row.Cells["ID"].Value.ToString();
                    txtCourseName.Text = row.Cells["CourseName"].Value.ToString();
                    txtCredits.Text = row.Cells["Credits"].Value.ToString();
                }
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridViewCourses.CurrentCell.RowIndex;
                var selectedCourse = courses[selectedIndex];

                selectedCourse.CourseName = txtCourseName.Text;
                selectedCourse.Credits = int.Parse(txtCredits.Text);

                SaveCourses();
                LoadCourses();
                MessageBox.Show("Course updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while updating the course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridViewCourses.CurrentCell.RowIndex;
                var selectedCourse = courses[selectedIndex];

                courses.Remove(selectedCourse);

                SaveCourses();
                LoadCourses();
                MessageBox.Show("Course deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while deleting the course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
