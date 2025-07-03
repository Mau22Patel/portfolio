using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EnrolmentSystem.EnrolmentSystemDataSetTableAdapters;

namespace EnrolmentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService

    {
        private EnrolmentSystemDataSetTableAdapters.StudentsTableAdapter studentTA = new EnrolmentSystemDataSetTableAdapters.StudentsTableAdapter();
        public List<Student>GetStudents()
        {

            EnrolmentSystemDataSet.StudentsDataTable  table = studentTA.GetData();
            List<Student> studentList = new List<Student>();

            foreach (DataRow row in table)
            {
                Student student = new Student();
                student.StudentName = row["StudentName"].ToString();
                student.StudentID = row ["StudentID"].ToString();
                student.DateEnrolled = row["DateEnrolled"].ToString();

                studentList.Add(student);
            }

            return studentList; 
            
        }

        public void AddNewStudent(string StudentName, string DateEnrolled)
        {
            studentTA.Insert(StudentName, DateEnrolled);
        }

    }
}
