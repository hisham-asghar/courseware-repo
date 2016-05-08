using Courseware.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System;
using System.Linq;
using Fizzler.Systems.HtmlAgilityPack;

namespace Courseware.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/

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


            return View("Site");
        }

        public ActionResult Site()
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
        public ActionResult World()
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
        public ActionResult GetJsonData()
        {
            string url = "http://news.google.com/";

       //     url = Server.MapPath("~/Content/data/SamplePage/GoogleNews.html");
            var list = News.GetNewsList(url);
            var alist = new List<News>();
            News obj = new News();
            obj.Title = "Lyari: 13 injured in Singo Lane cracker attack, culprit manages to escape";
            obj.Text =
                "KARACHI (Dunya News) - Cracker attack in Singo Lane Lyari on Sunday has left 13 injured while according to the police the incident took place near Uzair Baloch\u0026#39;s house but it was not the prime target, reported Dunya News.";
            obj.Image =
                "//t1.gstatic.com/images?q=tbn:ANd9GcSR9i-zBpP0VlcsbYTSCOCIYRk8k2ER9sLFVtB3bkdARfpfVfWvueybiHWyMae47pVQD2ZtWWvh";
            obj.Link = "http://nation.com.pk/karachi/08-May-2016/10-injured-in-lyari-grenade-attack";
            alist.Add(obj);
            return Json(list,JsonRequestBehavior.AllowGet);
        }
    }
}
