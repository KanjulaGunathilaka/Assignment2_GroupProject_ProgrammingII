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
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(324, 62);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 62;
            dataGridViewStudents.Size = new Size(360, 258);
            dataGridViewStudents.TabIndex = 0;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(416, 408);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(150, 31);
            txtStudentID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(416, 469);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(416, 534);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 3;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(416, 622);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(300, 31);
            dateTimePickerDOB.TabIndex = 4;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(416, 685);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(182, 33);
            comboBoxGender.TabIndex = 5;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = SystemColors.Highlight;
            btnAddStudent.Location = new Point(893, 445);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(195, 79);
            btnAddStudent.TabIndex = 6;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentID.Location = new Point(252, 410);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(141, 29);
            labelStudentID.TabIndex = 7;
            labelStudentID.Text = "Student ID:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(252, 471);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(143, 29);
            labelFirstName.TabIndex = 8;
            labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(253, 534);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(140, 29);
            labelLastName.TabIndex = 9;
            labelLastName.Text = "Last Name:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(259, 685);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(104, 29);
            labelGender.TabIndex = 10;
            labelGender.Text = "Gender:";
            // 
            // labelDOB
            // 
            labelDOB.AutoSize = true;
            labelDOB.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDOB.Location = new Point(231, 624);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(164, 29);
            labelDOB.TabIndex = 11;
            labelDOB.Text = "Date of Birth:";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 795);
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
    }
}