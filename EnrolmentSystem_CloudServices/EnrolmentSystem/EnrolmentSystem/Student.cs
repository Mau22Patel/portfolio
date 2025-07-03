using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EnrolmentSystem
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string StudentID { get; set; }

        [DataMember]
        public string StudentName { get; set; }

        [DataMember]
        public string DateEnrolled { get; set; }
    }
}