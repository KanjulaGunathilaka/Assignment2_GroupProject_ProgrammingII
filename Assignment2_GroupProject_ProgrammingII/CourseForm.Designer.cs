namespace Assignment2_GroupProject_ProgrammingII
{
    partial class CourseForm
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
            dataGridViewCourses = new DataGridView();
            txtCourseID = new TextBox();
            txtCourseName = new TextBox();
            txtCredits = new TextBox();
            btnAddCourse = new Button();
            labelCourseID = new Label();
            labelCourseName = new Label();
            labelCredits = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(575, 91);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 62;
            dataGridViewCourses.Size = new Size(360, 225);
            dataGridViewCourses.TabIndex = 0;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(278, 122);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(150, 31);
            txtCourseID.TabIndex = 1;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(278, 194);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(150, 31);
            txtCourseName.TabIndex = 2;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(278, 271);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(150, 31);
            txtCredits.TabIndex = 3;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCourse.ForeColor = SystemColors.Highlight;
            btnAddCourse.Location = new Point(218, 394);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(240, 76);
            btnAddCourse.TabIndex = 4;
            btnAddCourse.Text = "AddCourse";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // labelCourseID
            // 
            labelCourseID.AutoSize = true;
            labelCourseID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCourseID.Location = new Point(116, 124);
            labelCourseID.Name = "labelCourseID";
            labelCourseID.Size = new Size(133, 29);
            labelCourseID.TabIndex = 5;
            labelCourseID.Text = "Course ID:";
            // 
            // labelCourseName
            // 
            labelCourseName.AutoSize = true;
            labelCourseName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCourseName.Location = new Point(75, 191);
            labelCourseName.Name = "labelCourseName";
            labelCourseName.Size = new Size(174, 32);
            labelCourseName.TabIndex = 6;
            labelCourseName.Text = "Course Name:";
            // 
            // labelCredits
            // 
            labelCredits.AutoSize = true;
            labelCredits.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCredits.Location = new Point(148, 268);
            labelCredits.Name = "labelCredits";
            labelCredits.Size = new Size(101, 32);
            labelCredits.TabIndex = 7;
            labelCredits.Text = "Credits:";
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 687);
            Controls.Add(labelCredits);
            Controls.Add(labelCourseName);
            Controls.Add(labelCourseID);
            Controls.Add(btnAddCourse);
            Controls.Add(txtCredits);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(dataGridViewCourses);
            Name = "CourseForm";
            Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCourses;
        private TextBox txtCourseID;
        private TextBox txtCourseName;
        private TextBox txtCredits;
        private Button btnAddCourse;
        private Label labelCourseID;
        private Label labelCourseName;
        private Label labelCredits;
    }
}