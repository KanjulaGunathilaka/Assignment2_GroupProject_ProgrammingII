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
            dataGridViewEnrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnrollments.Location = new Point(631, 58);
            dataGridViewEnrollments.Name = "dataGridViewEnrollments";
            dataGridViewEnrollments.RowHeadersWidth = 62;
            dataGridViewEnrollments.Size = new Size(360, 225);
            dataGridViewEnrollments.TabIndex = 0;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(252, 58);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(182, 33);
            comboBoxStudents.TabIndex = 1;
            // 
            // comboBoxCourses
            // 
            comboBoxCourses.FormattingEnabled = true;
            comboBoxCourses.Location = new Point(252, 127);
            comboBoxCourses.Name = "comboBoxCourses";
            comboBoxCourses.Size = new Size(182, 33);
            comboBoxCourses.TabIndex = 2;
            // 
            // txtEnrollmentID
            // 
            txtEnrollmentID.Location = new Point(252, 201);
            txtEnrollmentID.Name = "txtEnrollmentID";
            txtEnrollmentID.Size = new Size(182, 31);
            txtEnrollmentID.TabIndex = 3;
            // 
            // dateTimePickerEnrollmentDate
            // 
            dateTimePickerEnrollmentDate.Location = new Point(228, 295);
            dateTimePickerEnrollmentDate.Name = "dateTimePickerEnrollmentDate";
            dateTimePickerEnrollmentDate.Size = new Size(300, 31);
            dateTimePickerEnrollmentDate.TabIndex = 4;
            // 
            // btnEnrollStudent
            // 
            btnEnrollStudent.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrollStudent.ForeColor = SystemColors.Highlight;
            btnEnrollStudent.Location = new Point(717, 379);
            btnEnrollStudent.Name = "btnEnrollStudent";
            btnEnrollStudent.Size = new Size(260, 89);
            btnEnrollStudent.TabIndex = 5;
            btnEnrollStudent.Text = "EnrollStudent";
            btnEnrollStudent.UseVisualStyleBackColor = true;
            btnEnrollStudent.Click += btnEnrollStudent_Click;
            // 
            // labelEnrollmentID
            // 
            labelEnrollmentID.AutoSize = true;
            labelEnrollmentID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEnrollmentID.Location = new Point(12, 201);
            labelEnrollmentID.Name = "labelEnrollmentID";
            labelEnrollmentID.Size = new Size(170, 29);
            labelEnrollmentID.TabIndex = 6;
            labelEnrollmentID.Text = "Enrollment ID";
            // 
            // labelStudent
            // 
            labelStudent.AutoSize = true;
            labelStudent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudent.Location = new Point(28, 71);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(103, 29);
            labelStudent.TabIndex = 7;
            labelStudent.Text = "Student";
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCourse.Location = new Point(34, 124);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(93, 32);
            labelCourse.TabIndex = 8;
            labelCourse.Text = "Course";
            // 
            // labelEnrollmentDate
            // 
            labelEnrollmentDate.AutoSize = true;
            labelEnrollmentDate.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEnrollmentDate.Location = new Point(18, 286);
            labelEnrollmentDate.Name = "labelEnrollmentDate";
            labelEnrollmentDate.Size = new Size(164, 29);
            labelEnrollmentDate.TabIndex = 9;
            labelEnrollmentDate.Text = "Enrollment Date";
            // 
            // EnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 666);
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