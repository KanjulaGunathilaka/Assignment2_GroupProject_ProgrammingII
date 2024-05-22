namespace Assignment2_GroupProject_ProgrammingII
{
    partial class MainForm
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
            btnStudents = new Button();
            btnCourses = new Button();
            btnEnrollments = new Button();
            btnTeachers = new Button();
            labelStudentFormButton = new Label();
            labelCourseFormButton = new Label();
            labelEnrollmentFormButton = new Label();
            labelTeacherFormButton = new Label();
            SuspendLayout();
            // 
            // btnStudents
            // 
            btnStudents.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.ForeColor = SystemColors.Highlight;
            btnStudents.Location = new Point(513, 114);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(222, 88);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnCourses
            // 
            btnCourses.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCourses.Location = new Point(513, 223);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(222, 78);
            btnCourses.TabIndex = 1;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // btnEnrollments
            // 
            btnEnrollments.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrollments.Location = new Point(513, 334);
            btnEnrollments.Name = "btnEnrollments";
            btnEnrollments.Size = new Size(222, 77);
            btnEnrollments.TabIndex = 2;
            btnEnrollments.Text = "Enrollments";
            btnEnrollments.UseVisualStyleBackColor = true;
            btnEnrollments.Click += btnEnrollments_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeachers.Location = new Point(513, 437);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(222, 83);
            btnTeachers.TabIndex = 3;
            btnTeachers.Text = "Teachers";
            btnTeachers.UseVisualStyleBackColor = true;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // labelStudentFormButton
            // 
            labelStudentFormButton.AutoSize = true;
            labelStudentFormButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentFormButton.ForeColor = SystemColors.MenuText;
            labelStudentFormButton.Location = new Point(168, 148);
            labelStudentFormButton.Name = "labelStudentFormButton";
            labelStudentFormButton.Size = new Size(213, 29);
            labelStudentFormButton.TabIndex = 4;
            labelStudentFormButton.Text = "Manage Students";
            // 
            // labelCourseFormButton
            // 
            labelCourseFormButton.AutoSize = true;
            labelCourseFormButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCourseFormButton.ForeColor = SystemColors.MenuText;
            labelCourseFormButton.Location = new Point(168, 252);
            labelCourseFormButton.Name = "labelCourseFormButton";
            labelCourseFormButton.Size = new Size(205, 29);
            labelCourseFormButton.TabIndex = 5;
            labelCourseFormButton.Text = "Manage Courses";
            // 
            // labelEnrollmentFormButton
            // 
            labelEnrollmentFormButton.AutoSize = true;
            labelEnrollmentFormButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEnrollmentFormButton.ForeColor = SystemColors.WindowText;
            labelEnrollmentFormButton.Location = new Point(168, 359);
            labelEnrollmentFormButton.Name = "labelEnrollmentFormButton";
            labelEnrollmentFormButton.Size = new Size(250, 32);
            labelEnrollmentFormButton.TabIndex = 6;
            labelEnrollmentFormButton.Text = "Manage Enrollments";
            // 
            // labelTeacherFormButton
            // 
            labelTeacherFormButton.AutoSize = true;
            labelTeacherFormButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTeacherFormButton.ForeColor = SystemColors.MenuText;
            labelTeacherFormButton.Location = new Point(169, 468);
            labelTeacherFormButton.Name = "labelTeacherFormButton";
            labelTeacherFormButton.Size = new Size(212, 29);
            labelTeacherFormButton.TabIndex = 7;
            labelTeacherFormButton.Text = "Manage Teachers";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 673);
            Controls.Add(labelTeacherFormButton);
            Controls.Add(labelEnrollmentFormButton);
            Controls.Add(labelCourseFormButton);
            Controls.Add(labelStudentFormButton);
            Controls.Add(btnTeachers);
            Controls.Add(btnEnrollments);
            Controls.Add(btnCourses);
            Controls.Add(btnStudents);
            ForeColor = SystemColors.MenuHighlight;
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudents;
        private Button btnCourses;
        private Button btnEnrollments;
        private Button btnTeachers;
        private Label labelStudentFormButton;
        private Label labelCourseFormButton;
        private Label labelEnrollmentFormButton;
        private Label labelTeacherFormButton;
    }
}