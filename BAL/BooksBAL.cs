using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAL
{
   public class BooksBAL
    {
        BooksDAL dal = new BooksDAL();


        public List<BookDTO> searchByName(string name)
        {
            return dal.searchByName(name);
        }

        public List<BookDTO> searchByAuthor(string aname)
        {
            return dal.searchByAuthor(aname);
        }
       public List<Book> searchAll ( )
        {
            return dal.searchAll();

        }
       public List<DepartmentDTO> searchDepartment()
       {
           return dal.searchDepartment();

       }
       public BookDTO ShowBook(string name)
       {
           return dal.ShowBook(name);

       }

       public List<Category> getDepatmentBooks()
       {
           throw new NotImplementedException();
       }
    }
}
