using System;
using System.Web.Mvc;
using jQuery.Validation.Unobtrusive.Native.Demos.Models;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Controllers
{
    public class AdvancedDemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            ViewBag.Title = "Advanced Demos and Documentation Overview";

            return View();
        }

        public ActionResult Dynamic()
        {
            ViewBag.Title = "Dynamic Demo";

            return View(new PersonModel());
        }

        public ActionResult CustomValidation()
        {
            ViewBag.Title = "Custom Validation Demo";

            return View(new CustomValidationModel());
        }

        public ActionResult Tooltip()
        {
            ViewBag.Title = "Tooltip";

            return View(new TooltipModel());
        }

        public ActionResult Globalize()
        {
            ViewBag.Title = "Globalize";

            return View(new GlobalizeModel());
        }

    }
}
