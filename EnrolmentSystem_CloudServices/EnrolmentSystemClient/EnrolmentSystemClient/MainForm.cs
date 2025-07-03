using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolmentSystemClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openStudentServiceBtn_Click(object sender, EventArgs e)
        {
            StudentsForm sf = new StudentsForm();
            sf.Show();
        }

        private void coursesServiceBtn_Click(object sender, EventArgs e)
        {
            CoursesForm cf = new CoursesForm();
            cf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnrolmentForm ef = new EnrolmentForm();
            ef.Show();
        }
    }
}
