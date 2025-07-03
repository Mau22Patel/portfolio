using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EnrolmentSystem
{
    [DataContract]
    public class Enrolment
    {
        [DataMember]
        public int StudentID { get; set; }

        [DataMember]
        public int CourseID { get; set; }

        [DataMember]
        public string Grade { get; set; }
    }


}