using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrolmentSystemClient.CoursesServiceReference;
using EnrolmentSystemClient.EnrolmentServiceReference;

namespace EnrolmentSystemClient
{
    public partial class EnrolmentForm : Form
    {
        public EnrolmentForm()
        {
            InitializeComponent();
        }

        private EnrolmentServiceClient client = new EnrolmentServiceClient();

        private void viewEnrolmentBtn_Click(object sender, EventArgs e)
        {
            enrolmentListBox.Items.Clear();

            foreach (Enrolment enrolment in client.ViewEnrolment())
            {
                {
                    enrolmentListBox.Items.Add("Student ID: " + enrolment.StudentID +
                             " | Course ID: " + enrolment.CourseID +
                             " | Grade: " + enrolment.Grade);

                }
            }
        }

        private void addEnrolmentBtn_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(studentidTextBox.Text);
            int courseID = Convert.ToInt32(courseidTextBox.Text);
            string grade = gradeTextBox.Text;

            client.AddEnrolment(studentID, courseID, grade);
            messageLabel.Text = "Record Added!";
        }

    }
}
