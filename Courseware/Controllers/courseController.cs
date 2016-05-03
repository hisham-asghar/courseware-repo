using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class courseController : Controller
    {
        //
        // GET: /course/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult material()
        {
            return View();
        }
        public ActionResult books()
        {
            return View();
        }
        public ActionResult certificate()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
    }
}
