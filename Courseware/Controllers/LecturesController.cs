using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class LecturesController : Controller
    {
        //
        // GET: /Lectures/

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


            return View();
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


            return View("ViewAll");
        }
        public ActionResult Course()
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
        public ActionResult Department()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }


            return View("dept");
        }

    }
}
