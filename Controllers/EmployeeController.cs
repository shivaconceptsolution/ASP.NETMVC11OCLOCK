using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace MVCWEBAPP.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection obj)
        {
            StringBuilder sb = new StringBuilder();
            String fname = obj["txtname"];
            String pass = obj["txtpass"];
            String tech = obj["r1"];
            int fee = 0;
            String stname = "";
            if (obj["c1"] != null)
            {
                fee += 1200;
                sb.Append(obj["c1"]);
            }

            if (obj["c2"] != null)
            {
                fee += 2200;
                sb.Append(obj["c2"]);
            }
            String country = obj["country"];
         

            foreach(object s in obj["State[]"])
            {
                //  stname += s + " ";
                stname = stname + s + "";
            }



            ViewBag.data = "Fullname is " + fname + " password is " + pass + " Technology is " + tech + " Basic Skills is  " + sb+" Fees is "+fee +"Country name is "+country + "State name is "+stname ;
            return View();
        }
    }
}