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
            ViewBag.Title = "Demos and Documentation Overview";

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

        public ActionResult Range()
        {
            ViewBag.Title = "Range";

            return View(new RangeModel());
        }

        public ActionResult MaxLengthMinLength()
        {
            ViewBag.Title = "MaxLength and MinLength";

            return View(new MaxLengthMinLengthModel { MaxLength = "12345678", MaxAndMinLength = "123" });
        }

        public ActionResult EqualTo()
        {
            ViewBag.Title = "EqualTo";

            return View(new EqualToModel { EMail = "an@emailaddress.com" });
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

        public ViewResult Remote()
        {
            ViewBag.Title = "Remote";

            return View(new RemoteModel());
        }

        public JsonResult RemoteSimple(string SimpleErrorMessage)
        {
            return Json(SimpleErrorMessage.StartsWith("a", true, null), JsonRequestBehavior.AllowGet);
        }

        public JsonResult RemoteServerErrorMessage(string ServerErrorMessage)
        {
            return Json((ServerErrorMessage.StartsWith("b", true, null)
                ? "true"
                : ServerErrorMessage + " does not begin with \"b\" and this message was sent back from the server as a result..."),
                JsonRequestBehavior.AllowGet);
        }

        public JsonResult RemoteAdditionalFields(string AdditionalFields, string SimpleErrorMessage)
        {
            return Json((AdditionalFields.StartsWith("c", true, null)
                ? "true"
                : AdditionalFields + " does not begin with \"c\" and this message was sent back from the server as a result..."),
                JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreditCard()
        {
            ViewBag.Title = "Credit Card";

            return View(new CreditCardModel());
        }


    }
}
