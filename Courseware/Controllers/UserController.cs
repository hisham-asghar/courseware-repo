using Entities;
using System;
using System.Web;
using System.Web.Mvc;
using BAL;
using System.IO;

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
        
        public ActionResult Update()
        {
            if (Session["user"] != null)
            {
                String uname = (string)Session["user"];
                UserBAL bal = new UserBAL();
                User dto = bal.getUser(uname);
                return View(dto);
            }
            else
            {
                return Redirect("~/");
            }
        }
        [HttpPost]
        public ActionResult UpdateProfile(HttpPostedFileBase pic,User user)
        {
            if (Session["user"] != null)
            {
                if (pic != null && pic.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + ".jpg";
                    string path = Path.Combine(Server.MapPath("~/Content/data"), fileName);
                    pic.SaveAs(path);
                    user.image = fileName;
                }
                else
                {
                    user.image = "";
                }
                String uname = (string)Session["user"];
                user.username = uname;
                UserBAL bal = new UserBAL();
                bal.updateUser(user);
                Session["img"] = user.image;
            } 
            return Redirect("~/");
        }
        [ActionName("logout")]
        public ActionResult Logout()
        {
            if (Session["user"] != null)
            {
                Session["user"] = null;
                Session["img"] = null;
            }
            return Redirect("~/");
        }

        [HttpPost]
        public ActionResult Login()
        {
            var uname = Request.Form["username"];
            var pass = Request.Form["password"];
            User dto = new User();
            dto.username = uname;
            dto.password = pass;
            UserBAL bal = new UserBAL();
            if (bal.verifyLogin(dto))
            {
                Session["user"] = uname;
                Session["img"] = dto.image;
                return Redirect("~/");
            }
            else
            {
                ViewBag.error = "Invalid username or Password";
                return View("Login");
            }
        }

        [HttpPost]
        public ActionResult Register(User dto)
        {
            UserBAL bal = new UserBAL();
            int i = bal.saveUser(dto);
            if (i > 0)
            {
                Session["user"] = dto.username;
                return Redirect("~/");
            }
            else
            {
                ViewBag.error = "Invalid username or Password";
                return Redirect("~/User#toregister");
            }
        }

    }
}
