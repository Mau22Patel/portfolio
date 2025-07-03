using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrolmentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EnrolmentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EnrolmentService.svc or EnrolmentService.svc.cs at the Solution Explorer and start debugging.
    public class EnrolmentService : IEnrolmentService
    {
        private EnrolmentSystemDataSetTableAdapters.EnrolmentsTableAdapter enrolmentTA = new EnrolmentSystemDataSetTableAdapters.EnrolmentsTableAdapter(); 

        public List<Enrolment>ViewEnrolment()
        {

            EnrolmentSystemDataSet.EnrolmentsDataTable table = enrolmentTA.GetData();
            List<Enrolment> enrolmentList = new List<Enrolment>();

            foreach (DataRow row in table)
            {
                Enrolment enrolment = new Enrolment();
                enrolment.StudentID = Convert.ToInt32(row["StudentID"]);
                enrolment.CourseID = Convert.ToInt32(row["CourseID"]);
                enrolment.Grade = row["Grade"].ToString();

                enrolmentList.Add(enrolment);
            }
            
            return enrolmentList;
        }

       public void AddEnrolment(int StudentID, int CourseID, string Grade)
        {
            enrolmentTA.Insert(StudentID, CourseID, Grade); 
        }

    }
}
