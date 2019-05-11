using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWEBAPP.Models;
namespace MVCWEBAPP.Controllers
{
    public class RectangleController : Controller
    {
        // GET: Rectangle
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AreaRect obj)
        {
            int area = obj.length * obj.width;
            ViewBag.Result = area;
            return View();
        }
    }
}