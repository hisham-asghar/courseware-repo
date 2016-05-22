using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace DAL
{
    public class CoursesDAL
    {
        public List<CourseDTO> searchByName(string str)
        {
            using (var ctx = new Entities.Entities())
            {
                var obj = from c in ctx.Courses
                          join d in ctx.Departments on c.dept_id equals d.dept_id
                          join f in ctx.Files on c.file_id equals f.file_id
                          where c.course_name.Contains(str)
                          select new CourseDTO
                          {
                              dept = d.dept_name,
                              id = c.course_id,
                              image = f.file_path,
                              name = c.course_name,
                              dept_id = c.dept_id
                          };
                return obj.ToList();
            }
        }
        public List<DepartmentDTO> searchDepartment()
        {
            using (var ctx = new Entities.Entities())
            {
                var obj = from d in ctx.Departments
                          join c in ctx.Courses on d.dept_id equals c.dept_id
                          select new DepartmentBookDTO
                          {
                              book_id = c.course_id,
                              book_name = c.course_name,
                              dept_id = d.dept_id,
                              dept_name = d.dept_name
                          };
                List<DepartmentDTO> list = new List<DepartmentDTO>();
                var deptz = obj.GroupBy(x => x.dept_id).ToList();

                foreach (var x in deptz)
                {
                    DepartmentDTO deptDto = new DepartmentDTO();
                    deptDto.dtos = new List<SimpleDTO>();
                    foreach (var dto in x)
                    {
                        deptDto.dept_id = dto.dept_id;
                        deptDto.dept_name = dto.dept_name;
                        deptDto.dtos.Add(new SimpleDTO { id = dto.book_id, name = dto.book_name });
                    }
                    list.Add(deptDto);
                }
                return list; 
            }
        }

        public CourseDTO getCourses(string s)
        {
            using (var ctx = new Entities.Entities())
            {
                var obj = from c in ctx.Courses
                          join d in ctx.Departments on c.dept_id equals d.dept_id
                          join f in ctx.Files on c.file_id equals f.file_id
                          where c.course_id+"" == s
                          select new CourseDTO
                          {
                              dept = d.dept_name,
                              desc = c.description,
                              id = c.course_id,
                              image = f.file_path,
                              name = c.course_name,
                              dept_id = c.dept_id
                          };
                return obj.FirstOrDefault();
            }   
        }
    }
}
