﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WikiPOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Product()
        {
            ViewBag.Message = "Products.";

            return View();
        }

        public ActionResult Category()
        {
            ViewBag.Message = "Category";

            return View();
        }
        public ActionResult Buy()
        {
            ViewBag.Message = "Buy";

            return View();
        }
        public ActionResult Reports()
        {
            ViewBag.Message = "Reports";

            return View();
        }
    }
}