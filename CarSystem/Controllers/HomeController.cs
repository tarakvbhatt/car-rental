﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarSystem.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 60)]
        public ActionResult About()
        {
            ViewBag.Message = "About Text";
            ViewBag.something = "Another Text";

            return View();
        }
        
        [OutputCache(Duration = 60)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calc(int? x)
        {

            return Content((x * 2).ToString());
        }

        [Route("CarCalculations/{x:range(1,12)?}/{y:range(1,12)?}")]
        [Route("Home/Calc/{x?}/{y?}")]
        public ActionResult Calc(int x = 1, int y = 2)
        {
            return Content($"{x * y}");
        }

        [Route("car/year/{year:regex(\\d{4})}/{month:range(1,12)}")]
        public ActionResult ByYear(int year, int month)
        {
            return Content(year + "-" + month);
        }

        public ActionResult CalculateSquareArea(double id)
        {
            return Content(Math.Pow(id, 2).ToString());
        }
    }
}