using BAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class MagzinesController : Controller
    {
        //
        // GET: /Magzines/
        
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

            
            return View("ViewAll");
        }

        public ActionResult GetJsonData()
        {
            string str = Request["str"];
            // bool name = bool.Parse(Request["name"]);
            // bool author = bool.Parse(Request["author"]);
            var response = new List<object>();
            var data = new List<object>();
            for (int i = 0; i < 10 && str != null && str.Trim() != ""; i++)
            {
                string ss = Guid.NewGuid().ToString();
                if (ss.Contains(str))
                {
                    object o = new
                    {
                        name = ss,
                        image = "img1.jpg"
                    };

                    data.Add(o);
                }
            }
            var obj = new
            {
                name = "By Name",data
            };
            response.Add(obj);
            return Json(response, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
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
        [HttpPost]
        [ActionName("Search")]
        public ActionResult Search2()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }
            string sh = Request.Form["textBox"];
            MagazineBAL bal = new MagazineBAL();
            var obj = bal.Search(sh);
            return View("Search", obj);

        }
        [HttpGet]
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
            MagazineBAL bal = new MagazineBAL();
            List<Magzine> m = bal.returnMagazines();

            return View("ViewALL",m);
        }

    }
}
