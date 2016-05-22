using Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BAL;

namespace Courseware.Controllers
{
    public class CourseController : Controller
    {
        //
        // GET: /course/

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
        public ActionResult Material()
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
            string str = Request["str"];
            var response = new List<object>();

            CoursesBAL bal = new CoursesBAL();
            response.Add(bal.searchByName(str));


            return Json(response, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Books()
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
        public ActionResult id()
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
                CoursesBAL bal = new CoursesBAL();
                CourseDTO dto = bal.getCourses(s);
                return View("ShowCourse", dto);
            }
            else
            {
                return Redirect("~/course/Department");
            }

        }
        public ActionResult Certificate()
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
            if (Request.Url.Segments.Length == 4)
            {
                string s = Request.Url.Segments[3];
                ViewBag.Sub = s;
            }

            CoursesBAL bal = new CoursesBAL();
            List<DepartmentDTO> c = bal.searchDepartment();
            return View("SearchByDepartment", c);
        }
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


            return View();
        }

    }
}
