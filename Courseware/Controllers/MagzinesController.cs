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
            var response = new List<object>();
            MagazineBAL bal = new MagazineBAL();
            response.Add(bal.Search(str));
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
        public ActionResult Category()
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
            List<MagzineDTO> m = bal.returnMagazines();

            return View("ViewALL", m);
        }
        public ActionResult Show()
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
                ViewBag.name = s.Replace("%20", " ");
                return View("ShowPDF");
            }


            return Redirect("~/Magzines/Category");
        }

    }
}
