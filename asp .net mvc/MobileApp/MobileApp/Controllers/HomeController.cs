using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileApp.Controllers
{
    using System.Web.WebPages;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [HttpGet]
        public ActionResult DisplayModes()
        {
            var model = DisplayModeProvider.Instance.Modes;

            return View(model);
        }

        [HttpPost]
        public ActionResult DisplayModes(string value)
        {
            switch (value)
            {
                case "mobile":
                    HttpContext.SetOverriddenBrowser(BrowserOverride.Mobile);
                    break;

                case "desktop":
                    HttpContext.SetOverriddenBrowser(BrowserOverride.Desktop);
                    break;
                case "silk":
                    HttpContext.SetOverriddenBrowser(@"Mozilla/5.0 (Linux; U; Android 4.2.2; en-us; KFTHWI Build/JDQ39) AppleWebKit/537.36 (KHTML, like Gecko) Silk/3.22 like Chrome/34.0.1847.137 Safari/537.36");
                    break;
                default:
                    HttpContext.ClearOverriddenBrowser();
                    break;
            }

            return RedirectToAction("DisplayModes");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
