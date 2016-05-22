using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace DAL
{
    public class LectureDAL
    {
        public List<Cours> returnLecByCourseNo()
        {
            Database ctx = new Database();
            List<Cours> c = ctx.Courses.ToList();
            return c;

        }
        public List<Department> getDepts()
        {
            Database ctx = new Database();
            List<Department> d = ctx.Departments.ToList();
            return d;
        }
        public Dictionary<KeyValuePair<string,string>,int> Search(string sh)
        {
           using( var ctx = new Database())
           {
              

             var obj = from l in ctx.Courses join j in ctx.Course_Material on l.course_id equals j.course_id where l.course_name.Contains(sh) select new { l.course_id, l.course_name, j.file_id };
             return obj.ToDictionary(l => new KeyValuePair<String, String>(l.course_id + "  ", l.course_name), j => j.file_id);
            
           }
            
        }
    }
}
