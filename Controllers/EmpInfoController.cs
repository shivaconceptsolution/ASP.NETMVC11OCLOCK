using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWEBAPP.Models;
namespace MVCWEBAPP.Controllers
{
    public class EmpInfoController : Controller
    {
        // GET: EmpInfo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Emp e)
        {
            ViewBag.Data = "Employee Code is " + e.EmpCode + " name is " + e.EmpName + " JOB IS  " + e.Job + " Salary is " + e.Salary;
            return View();
        }

    }
}