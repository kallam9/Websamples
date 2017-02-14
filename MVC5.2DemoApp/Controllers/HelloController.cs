using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5._2DemoApp.Models;

namespace MVC5._2DemoApp.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult SayHello(int fname, int lname)
        //public ActionResult SayHello()
        {
            //ViewBag.FirstName = fname;
            //ViewBag.LastName = lname;

            math1 p = new math1();

                p.i = fname;

            p.j = lname;


            return View(p);
        }
    }
}