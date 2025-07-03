namespace EnrolmentSystemClient
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
            this.title = new System.Windows.Forms.Label();
            this.openStudentServiceBtn = new System.Windows.Forms.Button();
            this.coursesServiceBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(145, 73);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(472, 38);
            this.title.TabIndex = 3;
            this.title.Text = "Welcome to the Enrolment System";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openStudentServiceBtn
            // 
            this.openStudentServiceBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStudentServiceBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.openStudentServiceBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.openStudentServiceBtn.Location = new System.Drawing.Point(259, 174);
            this.openStudentServiceBtn.Name = "openStudentServiceBtn";
            this.openStudentServiceBtn.Size = new System.Drawing.Size(201, 46);
            this.openStudentServiceBtn.TabIndex = 4;
            this.openStudentServiceBtn.Text = "Student Service ";
            this.openStudentServiceBtn.UseVisualStyleBackColor = true;
            this.openStudentServiceBtn.Click += new System.EventHandler(this.openStudentServiceBtn_Click);
            // 
            // coursesServiceBtn
            // 
            this.coursesServiceBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesServiceBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.coursesServiceBtn.Location = new System.Drawing.Point(259, 241);
            this.coursesServiceBtn.Name = "coursesServiceBtn";
            this.coursesServiceBtn.Size = new System.Drawing.Size(201, 44);
            this.coursesServiceBtn.TabIndex = 5;
            this.coursesServiceBtn.Text = "Course Service ";
            this.coursesServiceBtn.UseVisualStyleBackColor = true;
            this.coursesServiceBtn.Click += new System.EventHandler(this.coursesServiceBtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(259, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "Enrolment Service";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.coursesServiceBtn);
            this.Controls.Add(this.openStudentServiceBtn);
            this.Controls.Add(this.title);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button openStudentServiceBtn;
        private System.Windows.Forms.Button coursesServiceBtn;
        private System.Windows.Forms.Button button3;
    }
}