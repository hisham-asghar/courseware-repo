﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Courseware.Controllers
{
    public class LogInController : Controller
    {
        //
        // GET: /LogIn/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult signup()
        {
            return View();
        }
    }
}
