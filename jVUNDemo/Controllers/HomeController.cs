using System.Web.Mvc;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Welcome!";

            return View();
        }

        public ViewResult GettingStarted()
        {
            ViewBag.Title = "Getting Started";

            return View();
        }

        public ViewResult Download()
        {
            ViewBag.Title = "Download";

            return View();
        }

        public ViewResult License()
        {
            ViewBag.Title = "License";

            return View();
        }

        public ViewResult NotFound()
        {
            ViewBag.Title = "Page not found...";

            return View();
        }
    }
}
