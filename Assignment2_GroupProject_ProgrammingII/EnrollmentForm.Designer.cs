namespace Assignment2_GroupProject_ProgrammingII
{
    partial class EnrollmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewEnrollments = new DataGridView();
            comboBoxStudents = new ComboBox();
            comboBoxCourses = new ComboBox();
            txtEnrollmentID = new TextBox();
            dateTimePickerEnrollmentDate = new DateTimePicker();
            btnEnrollStudent = new Button();
            labelEnrollmentID = new Label();
            labelStudent = new Label();
            labelCourse = new Label();
            labelEnrollmentDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnrollments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEnrollments
            // 
            dataGridViewEnrollments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEnrollments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEnrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnrollments.Location = new Point(0, 299);
            dataGridViewEnrollments.Name = "dataGridViewEnrollments";
            dataGridViewEnrollments.RowHeadersWidth = 62;
            dataGridViewEnrollments.Size = new Size(837, 314);
            dataGridViewEnrollments.TabIndex = 0;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(223, 42);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(289, 33);
            comboBoxStudents.TabIndex = 1;
            // 
            // comboBoxCourses
            // 
            comboBoxCourses.FormattingEnabled = true;
            comboBoxCourses.Location = new Point(223, 99);
            comboBoxCourses.Name = "comboBoxCourses";
            comboBoxCourses.Size = new Size(289, 33);
            comboBoxCourses.TabIndex = 2;
            // 
            // txtEnrollmentID
            // 
            txtEnrollmentID.Location = new Point(223, 156);
            txtEnrollmentID.Name = "txtEnrollmentID";
            txtEnrollmentID.Size = new Size(289, 31);
            txtEnrollmentID.TabIndex = 3;
            // 
            // dateTimePickerEnrollmentDate
            // 
            dateTimePickerEnrollmentDate.Location = new Point(223, 217);
            dateTimePickerEnrollmentDate.Name = "dateTimePickerEnrollmentDate";
            dateTimePickerEnrollmentDate.Size = new Size(289, 31);
            dateTimePickerEnrollmentDate.TabIndex = 4;
            // 
            // btnEnrollStudent
            // 
            btnEnrollStudent.BackColor = SystemColors.ActiveCaption;
            btnEnrollStudent.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrollStudent.ForeColor = SystemColors.Highlight;
            btnEnrollStudent.Location = new Point(547, 42);
            btnEnrollStudent.Name = "btnEnrollStudent";
            btnEnrollStudent.Size = new Size(271, 59);
            btnEnrollStudent.TabIndex = 5;
            btnEnrollStudent.Text = "EnrollStudent";
            btnEnrollStudent.UseVisualStyleBackColor = false;
            btnEnrollStudent.Click += btnEnrollStudent_Click;
            // 
            // labelEnrollmentID
            // 
            labelEnrollmentID.AutoSize = true;
            labelEnrollmentID.BackColor = Color.Transparent;
            labelEnrollmentID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEnrollmentID.Location = new Point(19, 158);
            labelEnrollmentID.Name = "labelEnrollmentID";
            labelEnrollmentID.Size = new Size(170, 29);
            labelEnrollmentID.TabIndex = 6;
            labelEnrollmentID.Text = "Enrollment ID";
            // 
            // labelStudent
            // 
            labelStudent.AutoSize = true;
            labelStudent.BackColor = Color.Transparent;
            labelStudent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudent.Location = new Point(19, 42);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(103, 29);
            labelStudent.TabIndex = 7;
            labelStudent.Text = "Student";
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.BackColor = Color.Transparent;
            labelCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCourse.Location = new Point(19, 99);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(93, 32);
            labelCourse.TabIndex = 8;
            labelCourse.Text = "Course";
            // 
            // labelEnrollmentDate
            // 
            labelEnrollmentDate.AutoSize = true;
            labelEnrollmentDate.BackColor = Color.Transparent;
            labelEnrollmentDate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEnrollmentDate.Location = new Point(19, 219);
            labelEnrollmentDate.Name = "labelEnrollmentDate";
            labelEnrollmentDate.Size = new Size(197, 29);
            labelEnrollmentDate.TabIndex = 9;
            labelEnrollmentDate.Text = "Enrollment Date";
            // 
            // EnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sms;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(837, 627);
            Controls.Add(labelEnrollmentDate);
            Controls.Add(labelCourse);
            Controls.Add(labelStudent);
            Controls.Add(labelEnrollmentID);
            Controls.Add(btnEnrollStudent);
            Controls.Add(dateTimePickerEnrollmentDate);
            Controls.Add(txtEnrollmentID);
            Controls.Add(comboBoxCourses);
            Controls.Add(comboBoxStudents);
            Controls.Add(dataGridViewEnrollments);
            DoubleBuffered = true;
            Name = "EnrollmentForm";
            Text = "EnrollmentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnrollments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEnrollments;
        private ComboBox comboBoxStudents;
        private ComboBox comboBoxCourses;
        private TextBox txtEnrollmentID;
        private DateTimePicker dateTimePickerEnrollmentDate;
        private Button btnEnrollStudent;
        private Label labelEnrollmentID;
        private Label labelStudent;
        private Label labelCourse;
        private Label labelEnrollmentDate;
    }
}