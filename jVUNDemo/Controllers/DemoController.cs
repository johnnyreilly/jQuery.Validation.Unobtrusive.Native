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
            ViewBag.Title = "Overview";

            return View();
        }

        public ActionResult Number()
        {
            ViewBag.Title = "Number";

            return View(new NumberModel());
        }

        public ActionResult Date()
        {
            ViewBag.Title = "Date";

            return View(new DateModel { DateTime = DateTime.Today } );
        }

        public ActionResult Required()
        {
            ViewBag.Title = "Required";

            return View(new RequiredModel());
        }

        public ActionResult URL()
        {
            ViewBag.Title = "URL";

            return View(new UrlModel());
        }

        public ActionResult Email()
        {
            ViewBag.Title = "Email";

            return View(new EmailModel());
        }

        public ActionResult Dynamic()
        {
            ViewBag.Title = "Dynamic Demo";

            return View(new RequiredModel());
        }
    }
}
