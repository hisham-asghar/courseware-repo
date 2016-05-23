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
        public ActionResult Update()
        {
            object o = Session["user"];
            string uname = null;
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }

            if (ViewBag.Login != "admin")
                return Redirect("~/Books/");
            BooksBAL bal = new BooksBAL();
            List<BookDTO> list = bal.getBooks();
            return View(list);
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


            return Json(response, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult delete()
        {
            string id = Request["id"];
            BooksBAL bal = new BooksBAL();
            bal.delete(id);

            return Json("1", JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult updateBook()
        {
            string id = Request["id"];
            string name = Request["name"];
            string author = Request["author"];
            string cat = Request["cat"];
            BookDTO dto = new BookDTO();
            int res;
            int.TryParse(id,out res);
            dto.id = res;
            dto.name = name;
            dto.author = author;
            dto.category = cat;
            BooksBAL bal = new BooksBAL();
            bal.update(dto);

            return Json("1", JsonRequestBehavior.AllowGet);
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
