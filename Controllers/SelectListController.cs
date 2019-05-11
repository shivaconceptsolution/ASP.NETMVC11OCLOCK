using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEBAPP.Controllers
{
    public class SelectListController : Controller
    {
        // GET: SelectList
        public ActionResult Index()
        {
            List<SelectListItem> obj = new List<SelectListItem>();
            obj.Add(new SelectListItem {Text="C",Value="101" });
            obj.Add(new SelectListItem { Text = "CPP", Value = "102" });
            obj.Add(new SelectListItem { Text = "DS", Value = "103" });
            obj.Add(new SelectListItem { Text = "JAVA", Value = "104" });
            ViewBag.course = obj;
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection obj)
        {
            List<SelectListItem> obj1 = new List<SelectListItem>();
            obj1.Add(new SelectListItem { Text = "C", Value = "101" });
            obj1.Add(new SelectListItem { Text = "CPP", Value = "102" });
            obj1.Add(new SelectListItem { Text = "DS", Value = "103" });
            obj1.Add(new SelectListItem { Text = "JAVA", Value = "104" });
            ViewBag.course = obj1;

            ViewBag.res = obj["course"];
            ViewBag.res1 = obj["course1"];
            return View();
        }

    }
}