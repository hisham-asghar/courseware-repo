using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace DAL
{
    public class BooksDAL
    {
        public List<BookDTO> searchByName(string name)
        {
            using (var ctx = new Database())
            {
                var obj = from a in ctx.Authors
                          join c in ctx.Books on a.author_id equals c.author_id
                          join f in ctx.Files on c.file_id equals f.file_id
                          join i in ctx.Files on c.book_img equals i.file_id
                          where c.name.Contains(name)
                          select new BookDTO
                          {
                              author = a.author_name,
                              name = c.name,
                              image = i.file_path,
                              file = f.file_path
                          };
                return obj.ToList();
            }
            
        }

        public List<BookDTO> searchByAuthor(string aname)
        {
            using (var ctx = new Database())
            {
                var obj = from a in ctx.Authors
                          join c in ctx.Books on a.author_id equals c.author_id
                          join f in ctx.Files on c.file_id equals f.file_id
                          join i in ctx.Files on c.book_img equals i.file_id
                          where a.author_name.Contains(aname)
                          select new BookDTO
                          {
                              author = a.author_name,
                              name = c.name,
                              image = i.file_path,
                              file = f.file_path
                          };
                return obj.ToList();
            }
        }

        public List<Book> searchAll()
        {
            using (var ctx = new Database())
            {
                var obj = from a in ctx.Books select a; 
                return obj.ToList();
            }
        }

        public List<DepartmentDTO> searchDepartment()
        {
            using (var ctx = new Database())
            {
                var obj = from d in ctx.Categories
                          from b in ctx.Books
                          where d.cat_id == b.cat_id
                          select new DepartmentBookDTO
                          {
                              book_id = b.book_id,
                              book_name = b.name,
                              dept_id = d.cat_id,
                              dept_name = d.cat_name
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
        public BookDTO ShowBook(string id)
        {
            using (var ctx = new Database())
            {
                var obj = from b in ctx.Books
                          join f in ctx.Files on b.file_id equals f.file_id
                          join i in ctx.Files on b.book_img equals i.file_id
                          join a in ctx.Authors on b.author_id equals a.author_id
                          join c in ctx.Categories on b.cat_id equals c.cat_id
                          where b.book_id+"" == id
                          select new BookDTO
                          {
                              name = b.name,
                              author = a.author_name,
                              file = f.file_path,
                              image = i.file_path,
                              category = c.cat_name,
                              cat_id = c.cat_id
                          };
                return obj.FirstOrDefault();
            }
        }
    }
}
