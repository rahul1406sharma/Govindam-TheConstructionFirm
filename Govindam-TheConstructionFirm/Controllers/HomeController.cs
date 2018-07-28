using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Govindam_TheConstructionFirm.Controllers
{
    public class HomeController : Controller
    {
        //HOME PAGE
        public ActionResult Index()
        {
            ViewBag.TabHighlight = "HOME";
            return View();
        }

        //ABOUT US
        public ActionResult AboutUs()
        {
            ViewBag.TabHighlight = "ABOUTUS";
            return View();
        }

        //PROJECTS
        public ActionResult Projects()
        {
            ViewBag.TabHighlight = "PROJECTS";
            return View();
        }

        // ADDRESS
        public ActionResult Address()
        {
            ViewBag.TabHighlight = "ADDRESS";
            return View();
        }

        // CAREERS
        public ActionResult Careers()
        {
            ViewBag.TabHighlight = "CAREERS";
            return View();
        }

        //LOGIN
        public ActionResult Login()
        {
            ViewBag.TabHighlight = "LOGIN";
            return View();
        }
    }
}