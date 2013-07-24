using System.Web.Mvc;
using jQueryValidateNativeUnobtrusive.Models;

namespace jQueryValidateNativeUnobtrusive.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your demo page.";

            return View(new Example());
        }
    }
}
