using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CategoryWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FetchCatsSortedByLength()
        {
            using (var ctx = new CategoryWeb.Models.NORTHWNDEntities())
            {
                var list = ctx.Categories.
                    OrderBy(c=>c.CategoryName.Length).ToList();
                return PartialView(list);
            }
        }

        public ActionResult About()
        {
            using (var ctx = new CategoryWeb.Models.NORTHWNDEntities())
            {
                var list = ctx.Categories.ToList();
                return View(list);
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}