using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class StatisticsController : Controller
    {
        //
        // GET: /Statistics/

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


            return View("MonthlyStat");
        }
        public ActionResult ContactUs()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }


            return View("ContactUs");
        }
        public ActionResult Monthly()
        {
            object o = Session["user"];
            if (o != null)
            {
                ViewBag.Login = (string)o;
                o = Session["img"];
                string image = o != null ? (string)o : "user.png";
                ViewBag.Image = image;
            }


            return View("MonthlyStat");
        }

    }
}
