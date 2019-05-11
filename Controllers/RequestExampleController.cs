using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEBAPP.Controllers
{
    public class RequestExampleController : Controller
    {
        // GET: RequestExample
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int ?id)
        {
            String sname = Request["txtname"];
            ViewBag.data = "name is " + sname;
            return View();
        }

    }
}