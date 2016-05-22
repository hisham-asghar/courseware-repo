using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class CourseDTO
    {
        public int id { get; set; }
        public int dept_id { get; set; }
        public string image { get; set; }
        public string desc { get; set; }
        public string name { get; set; }
        public string dept { get; set; }
    }
}
