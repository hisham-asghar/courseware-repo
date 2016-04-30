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
            return View("Class");
        }

    }
}
