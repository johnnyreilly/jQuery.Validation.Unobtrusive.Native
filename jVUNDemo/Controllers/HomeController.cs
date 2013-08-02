using System.Web.Mvc;
using jQuery.Validation.Unobtrusive.Native.Demos.Models;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Welcome to jQuery.Validation.Unobtrusive.Native";

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

        public ActionResult BasicDemos()
        {
            ViewBag.Title = "Basic Demos";

            return View(new ExampleModel
            {
                RequiredDateDemo = null,
                StringLengthAndRequiredDemo = "abc",
                RangeAndNumberDemo = 77,
                DropDownRequiredDemo = null
            });
        }

        public ActionResult DemosOverview()
        {
            ViewBag.Title = "Overview of the demos";

            return View(new RequiredModel());
        }

        public ActionResult DemosNumber()
        {
            ViewBag.Title = "Number Demo";

            return View(new NumberModel());
        }

        public ActionResult DemosRequired()
        {
            ViewBag.Title = "Required Demo";

            return View(new RequiredModel());
        }

        public ActionResult DemosDynamic()
        {
            ViewBag.Title = "Dynamic Demo";

            return View(new RequiredModel());
        }

    }
}
