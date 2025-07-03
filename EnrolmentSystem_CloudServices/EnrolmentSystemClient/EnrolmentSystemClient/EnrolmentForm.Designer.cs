namespace EnrolmentSystemClient
{
    partial class EnrolmentForm
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
            this.viewEnrolmentBtn = new System.Windows.Forms.Button();
            this.enrolmentListBox = new System.Windows.Forms.ListBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.addEnrolmentBtn = new System.Windows.Forms.Button();
            this.studentidTextBox = new System.Windows.Forms.TextBox();
            this.courseidTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(275, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(256, 38);
            this.title.TabIndex = 2;
            this.title.Text = "Enrolment Service";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // viewEnrolmentBtn
            // 
            this.viewEnrolmentBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEnrolmentBtn.Location = new System.Drawing.Point(87, 119);
            this.viewEnrolmentBtn.Name = "viewEnrolmentBtn";
            this.viewEnrolmentBtn.Size = new System.Drawing.Size(178, 32);
            this.viewEnrolmentBtn.TabIndex = 3;
            this.viewEnrolmentBtn.Text = "Display Enrolments";
            this.viewEnrolmentBtn.UseVisualStyleBackColor = true;
            this.viewEnrolmentBtn.Click += new System.EventHandler(this.viewEnrolmentBtn_Click);
            // 
            // enrolmentListBox
            // 
            this.enrolmentListBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrolmentListBox.FormattingEnabled = true;
            this.enrolmentListBox.ItemHeight = 23;
            this.enrolmentListBox.Location = new System.Drawing.Point(87, 176);
            this.enrolmentListBox.Name = "enrolmentListBox";
            this.enrolmentListBox.Size = new System.Drawing.Size(378, 211);
            this.enrolmentListBox.TabIndex = 4;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.Location = new System.Drawing.Point(554, 176);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(86, 23);
            this.studentLabel.TabIndex = 5;
            this.studentLabel.Text = "StudentID";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(554, 216);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(80, 23);
            this.courseLabel.TabIndex = 6;
            this.courseLabel.Text = "CourseID";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(555, 262);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(56, 23);
            this.gradeLabel.TabIndex = 7;
            this.gradeLabel.Text = "Grade";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.messageLabel.Location = new System.Drawing.Point(559, 341);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(46, 23);
            this.messageLabel.TabIndex = 8;
            this.messageLabel.Text = "label";
            // 
            // addEnrolmentBtn
            // 
            this.addEnrolmentBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEnrolmentBtn.Location = new System.Drawing.Point(747, 341);
            this.addEnrolmentBtn.Name = "addEnrolmentBtn";
            this.addEnrolmentBtn.Size = new System.Drawing.Size(137, 33);
            this.addEnrolmentBtn.TabIndex = 9;
            this.addEnrolmentBtn.Text = "Add Enrolment";
            this.addEnrolmentBtn.UseVisualStyleBackColor = true;
            this.addEnrolmentBtn.Click += new System.EventHandler(this.addEnrolmentBtn_Click);
            // 
            // studentidTextBox
            // 
            this.studentidTextBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentidTextBox.Location = new System.Drawing.Point(737, 176);
            this.studentidTextBox.Name = "studentidTextBox";
            this.studentidTextBox.Size = new System.Drawing.Size(147, 30);
            this.studentidTextBox.TabIndex = 10;
            // 
            // courseidTextBox
            // 
            this.courseidTextBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidTextBox.Location = new System.Drawing.Point(737, 216);
            this.courseidTextBox.Name = "courseidTextBox";
            this.courseidTextBox.Size = new System.Drawing.Size(147, 30);
            this.courseidTextBox.TabIndex = 11;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTextBox.Location = new System.Drawing.Point(737, 262);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(147, 27);
            this.gradeTextBox.TabIndex = 12;
            // 
            // EnrolmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 547);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.courseidTextBox);
            this.Controls.Add(this.studentidTextBox);
            this.Controls.Add(this.addEnrolmentBtn);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.enrolmentListBox);
            this.Controls.Add(this.viewEnrolmentBtn);
            this.Controls.Add(this.title);
            this.Name = "EnrolmentForm";
            this.Text = "EnrolmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button viewEnrolmentBtn;
        private System.Windows.Forms.ListBox enrolmentListBox;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button addEnrolmentBtn;
        private System.Windows.Forms.TextBox studentidTextBox;
        private System.Windows.Forms.TextBox courseidTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
    }
}