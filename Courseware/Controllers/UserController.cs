using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /LogIn/

        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult logout()
        {
            if (Session["user"] != null)
            {
                Session["user"] = null;
            }
            return Redirect("~/");
        }

        [HttpPost]
        public ActionResult Login()
        {
            var uname = Request.Form["username"];
            var pass = Request.Form["password"];
            if (uname == "Hisham1234" && pass == "Abc12345")
            {
                Session["user"] = uname;
                return Redirect("~/");
            }
            else
            {
                ViewBag.error = "Invalid username or Password";
                return View("Login");
            }
        }

        [HttpPost]
        public ActionResult Register()
        {
            var uname = Request.Form["username"];
            var pass = Request.Form["password"];
            if (uname == "Hisham1234" && pass == "Abc12345")
            {
                Session["user"] = uname;
                return Redirect("~/");
            }
            else
            {
                ViewBag.error = "Invalid username or Password";
                return Redirect("~/User#toregitser");
            }
        }
    }
}
