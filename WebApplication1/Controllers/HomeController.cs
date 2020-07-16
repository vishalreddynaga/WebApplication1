using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {



            return "hellsllo";

        }
/*
        public string Index( string name )
        {

            return  name;

        }
*/
        public ActionResult About()
        {
            ViewBag.Message = "Your application description pageejjhhkkojjhhheee.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}