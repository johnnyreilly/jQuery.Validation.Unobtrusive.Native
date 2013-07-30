using System.Web.Mvc;
using jQuery.Validation.Unobtrusive.Native.Demos.Models;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to jQuery.Validation.Unobtrusive.Native";

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

    }
}
