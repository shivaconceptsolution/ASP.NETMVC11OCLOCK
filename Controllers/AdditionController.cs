using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEBAPP.Controllers
{
    public class AdditionController : Controller
    {
        // GET: Addition
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdditionCode(FormCollection obj)
        {
            int a = int.Parse(obj["txtnum1"]);
            int b = int.Parse(obj["txtnum2"]);
            int c = a + b;

            ViewBag.Result = "Result is " + c;

            return View();
        }
    }
}