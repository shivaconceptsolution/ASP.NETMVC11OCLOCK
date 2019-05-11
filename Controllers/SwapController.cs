using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEBAPP.Controllers
{
    public class SwapController : Controller
    {
        // GET: Swap
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Swapcode(FormCollection obj)
        {
            int a = int.Parse(obj["t1"]);
            int b = int.Parse(obj["t2"]);
            a = a + b;
            b = a - b;
            a = a - b;
            ViewBag.Result = "a=" + a + " b = " + b;


            return View();
        }
    }
}