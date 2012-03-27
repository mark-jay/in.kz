using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvc_Mysql_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Добро пожаловать в ASP.NET MVC!";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
