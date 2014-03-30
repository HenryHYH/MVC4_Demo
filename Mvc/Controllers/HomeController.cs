﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello world";

            return View();
        }

        public ActionResult Message()
        {
            ViewBag.Message = "Ajax message";
            return PartialView();
        }
    }
}
