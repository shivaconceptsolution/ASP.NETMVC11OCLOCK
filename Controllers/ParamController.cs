using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEBAPP.Controllers
{
    public class ParamController : Controller
    {
        // GET: Param
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string txtname,string txtmobile)
        {

            ViewBag.Result = "name is " + txtname + " mobileno is " + txtmobile;

            return View();
        }
    }
}