using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassingDatatoviewDemo.Controllers
{
    public class HomeController : Controller
    {
       // [ActionName("Default")]
       [HttpGet]
        public ActionResult Index()
            {

            return View("index");

            }

        [AcceptVerbs(HttpVerbs.Post)]
        [RequireHttps()]
        public ActionResult Index(string personName)
        {

            return View("index");

        }
        //public ActionResult Index(int? id = 10)
        //{
        //    //if (id.HasValue)
        //    //    ViewData["id"] = id.Value;

        //    //else
        //    //    ViewData["id"] = 0;
        //    //return View();

        //    //if (id.hasvalue)
        //    //    viewbag.id = id.value;

        //    //else
        //    //    viewbag.id = 0;
        //    //return view();


        //    if (id.HasValue)
        //        TempData["id"] = id.Value;

        //    else
        //        TempData["id"] = 0;
        //    TempData.Keep();
        //    return View();
        //}

        public ActionResult About()
        {
            int? id = (int?)TempData["id"];
            TempData.Keep();
           // ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}