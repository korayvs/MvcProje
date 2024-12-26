﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Senin Hakkında Sayfan.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Senin İletişim Sayfan.";

            return View();
        }

        public ActionResult Information()
        {
            return View();
        }

        public ActionResult MyProfile()
        {
            return View();
        }
    }
}