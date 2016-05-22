using BAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/

        public ActionResult Index()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }


            return View("Search");
        }

        public ActionResult GetJsonData()
        {
            string str = Request["str"];
            bool name = bool.Parse(Request["name"]);
            bool author = bool.Parse(Request["author"]);
            var response = new List<object>();

            if (name)
            {
                BooksBAL bal = new BooksBAL();
                var obj = bal.searchByName(str);
                response.Add(obj);
            } 
            if (author)
            {
                BooksBAL bal = new BooksBAL();
                var obj = bal.searchByAuthor(str);
                response.Add(obj);
            }


            return Json(response,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }


            return View();
        }
        public ActionResult Name()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }
            BooksBAL bal = new BooksBAL();
            List<Book> b;
            b = bal.searchAll(); 


            return View("SearchByBookName",b);
        }
        public ActionResult Subjects()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }

            if (Request.Url.Segments.Length == 4)
            {
                string s = Request.Url.Segments[3];
                ViewBag.Sub = s;
            }
            BooksBAL bal = new BooksBAL();
            List<DepartmentDTO> list = bal.searchDepartment();
            return View("SearchByDepartment", list);
        }
        public ActionResult ViewAll()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }

            BooksBAL bal = new BooksBAL();
            List<Book> b;
            string s = Request.Url.Segments[3];
           // b = bal.ShowBook();
            return View();
        }
        public ActionResult id()
        {

            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }

            BooksBAL bal = new BooksBAL();
            string s = Request.Url.Segments[3];
            BookDTO dto = bal.ShowBook(s);
            return View("ShowBook",dto);
        
        }

    }

    
}
