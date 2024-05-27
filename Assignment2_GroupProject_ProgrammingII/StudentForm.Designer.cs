namespace Assignment2_GroupProject_ProgrammingII
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            dataGridViewStudents = new DataGridView();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            comboBoxGender = new ComboBox();
            btnAddStudent = new Button();
            labelStudentID = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelGender = new Label();
            labelDOB = new Label();
            btnUpdateStudent = new Button();
            btnDeleteStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(28, 379);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 62;
            dataGridViewStudents.Size = new Size(969, 322);
            dataGridViewStudents.TabIndex = 0;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(257, 39);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(300, 31);
            txtStudentID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(257, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 31);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(257, 165);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 31);
            txtLastName.TabIndex = 3;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(257, 229);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(300, 31);
            dateTimePickerDOB.TabIndex = 4;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBoxGender.Location = new Point(257, 296);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(300, 33);
            comboBoxGender.TabIndex = 5;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = SystemColors.ActiveCaption;
            btnAddStudent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = SystemColors.Highlight;
            btnAddStudent.Location = new Point(685, 39);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(300, 79);
            btnAddStudent.TabIndex = 6;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.BackColor = Color.Transparent;
            labelStudentID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentID.Location = new Point(28, 39);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(141, 29);
            labelStudentID.TabIndex = 7;
            labelStudentID.Text = "Student ID:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(28, 100);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(143, 29);
            labelFirstName.TabIndex = 8;
            labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(28, 165);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(140, 29);
            labelLastName.TabIndex = 9;
            labelLastName.Text = "Last Name:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.BackColor = Color.Transparent;
            labelGender.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(28, 296);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(104, 29);
            labelGender.TabIndex = 10;
            labelGender.Text = "Gender:";
            // 
            // labelDOB
            // 
            labelDOB.AutoSize = true;
            labelDOB.BackColor = Color.Transparent;
            labelDOB.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDOB.Location = new Point(28, 231);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(164, 29);
            labelDOB.TabIndex = 11;
            labelDOB.Text = "Date of Birth:";
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.BackColor = SystemColors.ActiveCaption;
            btnUpdateStudent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStudent.ForeColor = SystemColors.Highlight;
            btnUpdateStudent.Location = new Point(685, 140);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(300, 79);
            btnUpdateStudent.TabIndex = 12;
            btnUpdateStudent.Text = "Update Student";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.BackColor = SystemColors.ActiveCaption;
            btnDeleteStudent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteStudent.ForeColor = SystemColors.Highlight;
            btnDeleteStudent.Location = new Point(685, 246);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(300, 79);
            btnDeleteStudent.TabIndex = 13;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseVisualStyleBackColor = false;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 716);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnUpdateStudent);
            Controls.Add(labelDOB);
            Controls.Add(labelGender);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelStudentID);
            Controls.Add(btnAddStudent);
            Controls.Add(comboBoxGender);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentID);
            Controls.Add(dataGridViewStudents);
            DoubleBuffered = true;
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private TextBox txtStudentID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dateTimePickerDOB;
        private ComboBox comboBoxGender;
        private Button btnAddStudent;
        private Label labelStudentID;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelGender;
        private Label labelDOB;
        private Button btnUpdateStudent;
        private Button btnDeleteStudent;
    }
}