using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAL
{
    public class CoursesBAL
    {
        CoursesDAL dal = new CoursesDAL();
        public List<CourseDTO> searchByName(string str)
        {
            return dal.searchByName(str);
        }
        public List<DepartmentDTO> searchDepartment()
        {
            return dal.searchDepartment();

        }

        public CourseDTO getCourses(string s)
        {
            return dal.getCourses(s);
        }
    }
}
