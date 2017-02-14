using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFiltersDemoApp.Controllers
{
    public class HomeController : Controller
    {
       // [OutputCache(Duration = 10, VaryByParam = "t1")]
        public ActionResult Index()
        {
            


            return View();
        }
[HttpPost]
[ValidateInput(false)]
[ValidateAntiForgeryToken]
        public ActionResult Index(string txtDemo)
        {
             ViewBag.id = txtDemo;

            return View();
        }

        //[Authorize]
        [HandleError]
        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            throw new ApplicationException("Hell Yeah.....");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}