using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forms.Models;
using System.Text;
namespace Forms.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult form()
        {
            formmodel model = new formmodel();


            return View(model);
        }

        //public ActionResult Details()
        //{

        //    return View();
        //    TempData.Keep();

        //}


        //[HttpPost]
        //public ActionResult form(formmodel model)
        //{

        //    StringBuilder detail = new StringBuilder();
        //    detail.Append("<b>Name :</b> " + model.Name + "<br/>");
        //    detail.Append("<b>Fathersname :</b> " + model.Fathersname + "<br/>");
        //    detail.Append("<b>DateofBirt :</b> " + model.DateofBirth + "<br/>");
        //    detail.Append("<b>EmailId :</b> " + model.EmailID);
        //    return View(detail);
        //}

        //[HttpPost]

        //public ActionResult form(string txtName, string txtFathersname, string txtDateofbirth, string txtEmailID)
        //{
        //    TempData["Name"] = txtName;
        //    TempData["Fathersname"] = txtFathersname;

        //    TempData["Dateofbirth"] = txtDateofbirth;
        //    TempData["EmailID"] = txtEmailID;

        //    TempData.Keep();

        //    return View();
        //}

        public ActionResult Details(string txtName, string txtFathersname, string txtDateofbirth, string txtEmailID)
        {
            TempData["Name"] = txtName;
            TempData["Fathersname"] = txtFathersname;

            TempData["Dateofbirth"] = txtDateofbirth;
            TempData["EmailID"] = txtEmailID;

            TempData.Keep();

            return View();
        }
    }
}