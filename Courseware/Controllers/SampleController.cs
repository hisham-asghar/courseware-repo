using Courseware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class SampleController : Controller
    {
        //
        // GET: /Sample/

        public ActionResult Index()
        {
            User u = new User();
            ViewBag.image = "/Content/images/img.jpg";
            ViewBag.name = "Hisham";
            return View(u);
        }

    }
}
