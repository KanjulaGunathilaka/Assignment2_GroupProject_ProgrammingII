﻿namespace Assignment2_GroupProject_ProgrammingII
{
    partial class TeacherForm
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
            dataGridViewTeachers = new DataGridView();
            txtTeacherID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSubject = new TextBox();
            btnAddTeacher = new Button();
            labelTeacherID = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelSubject = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTeachers
            // 
            dataGridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers.Location = new Point(279, 25);
            dataGridViewTeachers.Name = "dataGridViewTeachers";
            dataGridViewTeachers.RowHeadersWidth = 62;
            dataGridViewTeachers.Size = new Size(360, 225);
            dataGridViewTeachers.TabIndex = 0;
            // 
            // txtTeacherID
            // 
            txtTeacherID.Location = new Point(336, 299);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.Size = new Size(150, 31);
            txtTeacherID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(336, 348);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(336, 399);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 3;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(336, 454);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(150, 31);
            txtSubject.TabIndex = 4;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTeacher.ForeColor = SystemColors.Highlight;
            btnAddTeacher.Location = new Point(745, 320);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(205, 95);
            btnAddTeacher.TabIndex = 5;
            btnAddTeacher.Text = "Add Teacher";
            btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // labelTeacherID
            // 
            labelTeacherID.AutoSize = true;
            labelTeacherID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTeacherID.Location = new Point(168, 299);
            labelTeacherID.Name = "labelTeacherID";
            labelTeacherID.Size = new Size(141, 32);
            labelTeacherID.TabIndex = 6;
            labelTeacherID.Text = "Teacher ID:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(165, 348);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(144, 32);
            labelFirstName.TabIndex = 7;
            labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(169, 401);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(140, 29);
            labelLastName.TabIndex = 8;
            labelLastName.Text = "Last Name:";
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSubject.Location = new Point(202, 456);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(107, 29);
            labelSubject.TabIndex = 9;
            labelSubject.Text = "Subject:";
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 567);
            Controls.Add(labelSubject);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelTeacherID);
            Controls.Add(btnAddTeacher);
            Controls.Add(txtSubject);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTeacherID);
            Controls.Add(dataGridViewTeachers);
            Name = "TeacherForm";
            Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTeachers;
        private TextBox txtTeacherID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSubject;
        private Button btnAddTeacher;
        private Label labelTeacherID;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelSubject;
    }
}