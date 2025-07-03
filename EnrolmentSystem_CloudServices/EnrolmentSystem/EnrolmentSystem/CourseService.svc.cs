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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CourseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CourseService.svc or CourseService.svc.cs at the Solution Explorer and start debugging.

    public class CourseService : ICourseService

    { 
    
             private EnrolmentSystemDataSetTableAdapters.CoursesTableAdapter courseTA = new EnrolmentSystemDataSetTableAdapters.CoursesTableAdapter();
   
            public List<Course> ViewCourse()

             {
            EnrolmentSystemDataSet.CoursesDataTable table = courseTA.GetData();
            List<Course> CourseList = new List<Course>();

            foreach (DataRow row in table)
            {
                Course course = new Course();
                course.CourseID = row["CourseID"].ToString();
                course.CourseName = row["CourseName"].ToString();
                course.Cost = Convert.ToDecimal(row["Cost"]);

                CourseList.Add(course);
            }
        
            return CourseList;
            
        }
            
        

        public void AddCourse( string CourseName, decimal Cost)

        {
            courseTA.Insert(CourseName, Cost);
        }
    }
}

