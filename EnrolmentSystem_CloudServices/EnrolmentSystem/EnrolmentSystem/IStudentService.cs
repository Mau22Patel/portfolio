﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnrolmentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {

        [OperationContract]
        List <Student> GetStudents ();

        [OperationContract]
        void AddNewStudent (string StudentName, string DateEnrolled);

    
        
    }
}
