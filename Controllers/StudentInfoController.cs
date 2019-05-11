using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEBAPP.Controllers
{
    public class StudentInfoController : Controller
    {
        [HttpGet]
        public ActionResult Index() //ActionResult is the abstract class which return View Object
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(FormCollection obj)
        {
            ViewBag.RNO =     "Rollno is " + obj["txtroll"];
            ViewBag.Name =    "name is " + obj["txtname"];
            ViewBag.Branch =  "branch is " + obj["txtbranch"];
            ViewBag.Fees=     "Fees is " + obj["txtfees"];
                
            return View();
        }

    }
}