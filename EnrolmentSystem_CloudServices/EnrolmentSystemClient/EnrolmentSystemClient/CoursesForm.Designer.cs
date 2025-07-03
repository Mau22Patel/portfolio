namespace EnrolmentSystemClient
{
    partial class CoursesForm
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
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.viewCoursesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(293, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(208, 38);
            this.title.TabIndex = 1;
            this.title.Text = "Course Service";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // coursesListBox
            // 
            this.coursesListBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.ItemHeight = 23;
            this.coursesListBox.Location = new System.Drawing.Point(70, 168);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(350, 211);
            this.coursesListBox.TabIndex = 3;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(451, 168);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(114, 23);
            this.courseNameLabel.TabIndex = 4;
            this.courseNameLabel.Text = "Course Name";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(451, 210);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(44, 23);
            this.costLabel.TabIndex = 5;
            this.costLabel.Text = "Cost";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.messageLabel.Location = new System.Drawing.Point(451, 333);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 23);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "Label";
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(584, 210);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(165, 30);
            this.costTextBox.TabIndex = 7;
            // 
            // courseTextBox
            // 
            this.courseTextBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTextBox.Location = new System.Drawing.Point(584, 168);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(165, 30);
            this.courseTextBox.TabIndex = 8;
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.Location = new System.Drawing.Point(629, 287);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(120, 37);
            this.addCourseBtn.TabIndex = 9;
            this.addCourseBtn.Text = "Add Course";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // viewCoursesButton
            // 
            this.viewCoursesButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCoursesButton.Location = new System.Drawing.Point(70, 116);
            this.viewCoursesButton.Name = "viewCoursesButton";
            this.viewCoursesButton.Size = new System.Drawing.Size(167, 36);
            this.viewCoursesButton.TabIndex = 10;
            this.viewCoursesButton.Text = "Display Courses ";
            this.viewCoursesButton.UseVisualStyleBackColor = true;
            this.viewCoursesButton.Click += new System.EventHandler(this.viewCoursesButton_Click);
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewCoursesButton);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.coursesListBox);
            this.Controls.Add(this.title);
            this.Name = "CoursesForm";
            this.Text = "CoursesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Button viewCoursesButton;
    }
}