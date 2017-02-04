using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = new HtmlString("<b>Your application description page.</b>");
            Session["test"] = "Oleg2";

            return View();
        }

        public ActionResult Contact()
        {
            var yourName = Session["test"];
            ViewBag.Message = $"Your contact page - {yourName}. {DateTime.Now:dd.MM.yyyy}";

            return View();
        }
    }
}