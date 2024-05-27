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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            btnStudents.BackColor = SystemColors.ActiveCaption;
            btnStudents.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.ForeColor = SystemColors.Highlight;
            btnStudents.Location = new Point(693, 86);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(355, 125);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnCourses
            // 
            btnCourses.BackColor = SystemColors.ActiveCaption;
            btnCourses.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCourses.Location = new Point(693, 217);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(355, 115);
            btnCourses.TabIndex = 1;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = false;
            btnCourses.Click += btnCourses_Click;
            // 
            // btnEnrollments
            // 
            btnEnrollments.BackColor = SystemColors.ActiveCaption;
            btnEnrollments.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrollments.Location = new Point(693, 338);
            btnEnrollments.Name = "btnEnrollments";
            btnEnrollments.Size = new Size(355, 114);
            btnEnrollments.TabIndex = 2;
            btnEnrollments.Text = "Enrollments";
            btnEnrollments.UseVisualStyleBackColor = false;
            btnEnrollments.Click += btnEnrollments_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.BackColor = SystemColors.ActiveCaption;
            btnTeachers.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeachers.Location = new Point(693, 458);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(355, 120);
            btnTeachers.TabIndex = 3;
            btnTeachers.Text = "Teachers";
            btnTeachers.UseVisualStyleBackColor = false;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // labelStudentFormButton
            // 
            labelStudentFormButton.AutoSize = true;
            labelStudentFormButton.BackColor = Color.Transparent;
            labelStudentFormButton.Font = new Font("Arial", 20F, FontStyle.Bold);
            labelStudentFormButton.ForeColor = SystemColors.Highlight;
            labelStudentFormButton.Location = new Point(101, 124);
            labelStudentFormButton.Name = "labelStudentFormButton";
            labelStudentFormButton.Size = new Size(421, 46);
            labelStudentFormButton.TabIndex = 4;
            labelStudentFormButton.Text = "MANAGE STUDENTS";
            // 
            // labelCourseFormButton
            // 
            labelCourseFormButton.AutoSize = true;
            labelCourseFormButton.BackColor = Color.Transparent;
            labelCourseFormButton.Font = new Font("Arial", 20F, FontStyle.Bold);
            labelCourseFormButton.ForeColor = SystemColors.HotTrack;
            labelCourseFormButton.Location = new Point(101, 250);
            labelCourseFormButton.Name = "labelCourseFormButton";
            labelCourseFormButton.Size = new Size(404, 46);
            labelCourseFormButton.TabIndex = 5;
            labelCourseFormButton.Text = "MANAGE COURSES";
            // 
            // labelEnrollmentFormButton
            // 
            labelEnrollmentFormButton.AutoSize = true;
            labelEnrollmentFormButton.BackColor = Color.Transparent;
            labelEnrollmentFormButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelEnrollmentFormButton.ForeColor = SystemColors.HotTrack;
            labelEnrollmentFormButton.Location = new Point(101, 365);
            labelEnrollmentFormButton.Name = "labelEnrollmentFormButton";
            labelEnrollmentFormButton.Size = new Size(494, 54);
            labelEnrollmentFormButton.TabIndex = 6;
            labelEnrollmentFormButton.Text = "MANAGE ENROLLMENTS";
            // 
            // labelTeacherFormButton
            // 
            labelTeacherFormButton.AutoSize = true;
            labelTeacherFormButton.BackColor = Color.Transparent;
            labelTeacherFormButton.Font = new Font("Arial", 20F, FontStyle.Bold);
            labelTeacherFormButton.ForeColor = SystemColors.HotTrack;
            labelTeacherFormButton.Location = new Point(101, 494);
            labelTeacherFormButton.Name = "labelTeacherFormButton";
            labelTeacherFormButton.Size = new Size(424, 46);
            labelTeacherFormButton.TabIndex = 7;
            labelTeacherFormButton.Text = "MANAGE TEACHERS";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1115, 671);
            Controls.Add(labelTeacherFormButton);
            Controls.Add(labelEnrollmentFormButton);
            Controls.Add(labelCourseFormButton);
            Controls.Add(labelStudentFormButton);
            Controls.Add(btnTeachers);
            Controls.Add(btnEnrollments);
            Controls.Add(btnCourses);
            Controls.Add(btnStudents);
            DoubleBuffered = true;
            ForeColor = SystemColors.MenuHighlight;
            Name = "MainForm";
            Text = "StudentManagementSystem";
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