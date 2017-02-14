using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersDemoApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public string SayHello(string fname,string lname)
        {
            return $"Hello {fname} {lname}";

            //This  is called string interpolation a new feature of C# 6
        }
    }
}