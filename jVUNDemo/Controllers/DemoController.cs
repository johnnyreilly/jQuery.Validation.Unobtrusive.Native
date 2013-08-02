using System;
using System.Web.Mvc;
using jQuery.Validation.Unobtrusive.Native.Demos.Models;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            ViewBag.Title = "Overview of the demos";

            return View();
        }

        public ActionResult Number()
        {
            ViewBag.Title = "Number Demo";

            return View(new NumberModel());
        }

        public ActionResult Date()
        {
            ViewBag.Title = "Date Demo";

            return View(new DateModel { DateTime = DateTime.Today } );
        }

        public ActionResult Required()
        {
            ViewBag.Title = "Required Demo";

            return View(new RequiredModel());
        }

        public ActionResult URL()
        {
            ViewBag.Title = "URL Demo";

            return View(new UrlModel());
        }

        public ActionResult Dynamic()
        {
            ViewBag.Title = "Dynamic Demo";

            return View(new RequiredModel());
        }
    }
}
