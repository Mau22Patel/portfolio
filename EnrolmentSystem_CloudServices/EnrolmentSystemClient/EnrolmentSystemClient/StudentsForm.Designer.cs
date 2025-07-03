namespace EnrolmentSystemClient
{
    partial class StudentsForm
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
            this.title = new System.Windows.Forms.Label();
            this.displayStudentsBtn = new System.Windows.Forms.Button();
            this.StudentNamelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.dateEnrolledTextBox = new System.Windows.Forms.TextBox();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(151, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(230, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Student Service ";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // displayStudentsBtn
            // 
            this.displayStudentsBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStudentsBtn.Location = new System.Drawing.Point(53, 121);
            this.displayStudentsBtn.Name = "displayStudentsBtn";
            this.displayStudentsBtn.Size = new System.Drawing.Size(242, 42);
            this.displayStudentsBtn.TabIndex = 1;
            this.displayStudentsBtn.Text = "Display all Students ";
            this.displayStudentsBtn.UseVisualStyleBackColor = true;
            this.displayStudentsBtn.Click += new System.EventHandler(this.displayStudentsBtn_Click);
            // 
            // StudentNamelabel
            // 
            this.StudentNamelabel.AutoSize = true;
            this.StudentNamelabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNamelabel.Location = new System.Drawing.Point(447, 186);
            this.StudentNamelabel.Name = "StudentNamelabel";
            this.StudentNamelabel.Size = new System.Drawing.Size(125, 23);
            this.StudentNamelabel.TabIndex = 3;
            this.StudentNamelabel.Text = "Student Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date Enrolled";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.Location = new System.Drawing.Point(621, 311);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(132, 45);
            this.addStudentButton.TabIndex = 5;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(590, 186);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(163, 22);
            this.studentNameTextBox.TabIndex = 6;
            // 
            // dateEnrolledTextBox
            // 
            this.dateEnrolledTextBox.Location = new System.Drawing.Point(590, 234);
            this.dateEnrolledTextBox.Name = "dateEnrolledTextBox";
            this.dateEnrolledTextBox.Size = new System.Drawing.Size(163, 22);
            this.dateEnrolledTextBox.TabIndex = 7;
            // 
            // studentListBox
            // 
            this.studentListBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 23;
            this.studentListBox.Location = new System.Drawing.Point(53, 186);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(274, 234);
            this.studentListBox.TabIndex = 8;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.messageLabel.Location = new System.Drawing.Point(451, 311);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 23);
            this.messageLabel.TabIndex = 9;
            this.messageLabel.Text = "Label";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.dateEnrolledTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentNamelabel);
            this.Controls.Add(this.displayStudentsBtn);
            this.Controls.Add(this.title);
            this.Name = "StudentsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button displayStudentsBtn;
        private System.Windows.Forms.Label StudentNamelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox dateEnrolledTextBox;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label messageLabel;
    }
}

