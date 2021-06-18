using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace storelaptop.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Chart()
        {
            return View();
        }
        public ActionResult Table()
        {
            return View();
        }
        public ActionResult layoutstatic()
        {
            return View();
        }
        public ActionResult layoutsidenavlight()
        {
            return View();
        }
        public ActionResult error401()
        {
            return View();
        }
        public ActionResult error404()
        {
            return View();
        }
        public ActionResult error500()
        {
            return View();
        }
    }
}