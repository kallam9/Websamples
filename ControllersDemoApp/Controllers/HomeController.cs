using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersDemoApp.Controllers
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

            return RedirectToRoute("SayhellotoAbcd");
           // return RedirectToAction("SayHello","Demo",new { fname = "Govardhan", lname = "reddy" });
        }

      public  class person
        {
            public string FirstName;

            public string LastName;


        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            // return Content("<name><firstname>Govardhan</firstname></name>","text/xml");

            // return File(Server.MapPath("~/TextFile1.txt"), "text/plain", "TextFile1.txt");

            // return JavaScript("alert('js Demo')");

            person p = new person(){FirstName = "fname",LastName = "lname" };
            //return Json(p, JsonRequestBehavior.AllowGet);
            //return null;

            // return HttpNotFound();

            return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest,"Bad Request");

            // By Default the MVC framework treats all public methods of a controller class as action methods.
            //if your controller class contains a public methods of a controller class as action methods, 
            //if your controller class contains a public method that you do not want to be  action method you can
            // Mark it as Non Action attribute [NonAction]
      
        }
    }
}