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



namespace EnrolmentSystemClient
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        private CourseServiceClient client = new CourseServiceClient();
        private void viewCoursesButton_Click(object sender, EventArgs e)
        {
            coursesListBox.Items.Clear();

            foreach (Course course in client.ViewCourse())
            {
                {
                    coursesListBox.Items.Add(course.CourseName + " " + course.Cost + " ");
                }
            }

        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            string courseName = courseTextBox.Text;
            decimal cost = Convert.ToDecimal(costTextBox.Text);
            client.AddCourse(courseName, cost);
            messageLabel.Text = "Record Added!";
        }
    }
}
