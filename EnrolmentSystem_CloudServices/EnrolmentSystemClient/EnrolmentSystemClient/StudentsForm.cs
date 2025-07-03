using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrolmentSystemClient.StudentServiceReference;



namespace EnrolmentSystemClient
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }
        
        private StudentServiceClient client = new StudentServiceClient();




        private void displayStudentsBtn_Click(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();

            foreach (Student student in client.GetStudents())
            {
                {
                    studentListBox.Items.Add(student.StudentID + " " + student.StudentName + " " + student.DateEnrolled);
                }
            }

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string studentName = studentNameTextBox.Text;
            string dateEnrolled = dateEnrolledTextBox.Text;
            client.AddNewStudent(studentName, dateEnrolled);
            messageLabel.Text = "Record Added!";

        }
    }
}