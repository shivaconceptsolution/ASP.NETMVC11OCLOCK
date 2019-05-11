using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEBAPP.Controllers
{
    public class CheckBoxexampleController : Controller
    {
        // GET: CheckBoxexample
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection obj)
        {
            string s = "";
            foreach(object o in obj["chk[]"])
            {
                s = s+o;
               // if(!o.ToString().Equals("true") || !o.ToString().Equals("false"))
               // s = s + o;
            }
            /*  int c = 0;
              for (int i = 0; i < s.Length; i++)
              {
                  if (s[i] == ',')
                      c++;

              }
              string[] str = new string[c+1];
              int j = 0;
              for(int i=0;i<s.Length;i++)
              {
                  if(s[i]==',')
                  {
                      j++;
                  }
                  else
                  {
                      str[j] = "" + s[i];

                  }

              }*/
            var s1 = s.Split(',');
            String s2 = "";
            for(int i=0;i<s1.Length;i++)
            {
                if (s1[i] != "false")
                    s2 += s1[i];

            }

            ViewBag.data = s2;
            return View();
        }
    }
}