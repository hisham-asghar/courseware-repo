using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class ClassroomsController : Controller
    {
        //
        // GET: /Classrooms/

        public ActionResult Index()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
            }
            return View("Class");
        }
        public ActionResult Reports()
        {
            return View();
        }
        public ActionResult Feedback()
        {
            return View();
        }
    }
}
