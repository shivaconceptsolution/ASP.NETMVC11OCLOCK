using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEBAPP.Controllers
{
    public class SIController : Controller
    {
        // GET: SI
        public ActionResult Index()
        {
            float p = 5000;
            float r = 2.2F;
            float t = 2.2F;
            float si = (p * r * t) / 100;
            ViewBag.Result = si;
            return View();
        }
    }
}