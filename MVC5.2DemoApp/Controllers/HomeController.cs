using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5._2DemoApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About(string id)
        {
            if (id == null)
                return View();
            return View("contact");
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}