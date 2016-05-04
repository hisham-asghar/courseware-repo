using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/

        public ActionResult Index()
        {
            return View();
        }
         public ActionResult Search()
        {
            return View();
        }
        public ActionResult SearchByBookName()
        {
            return View();
        }
        public ActionResult SearchByDepartment()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View();
        }

    }

    
}
