using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrolmentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICourseService" in both code and config file together.
    [ServiceContract]
    public interface ICourseService
    {
        [OperationContract]
        List<Course> ViewCourse();

        [OperationContract]
        void AddCourse(String CourseName, Decimal Cost );

    }
}


