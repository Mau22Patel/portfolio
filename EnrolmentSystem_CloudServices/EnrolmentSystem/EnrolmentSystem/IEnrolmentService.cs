using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrolmentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnrolmentService" in both code and config file together.
    [ServiceContract]
    public interface IEnrolmentService
    {
        [OperationContract]
        List<Enrolment> ViewEnrolment();

        [OperationContract]
        void AddEnrolment(int StudentID, int CourseID, string Grade);
    }
}
