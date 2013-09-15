using System.Web.Mvc;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    public static class HtmlHelperFactory
    {
        internal static HtmlHelper<T> Create<T>(T model)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            var vc = new ViewContext
                {
                    HttpContext = new FakeHttpContext(),
                    ViewData = new ViewDataDictionary(model)
                };

            var htmlHelper = new HtmlHelper<T>(vc, new FakeViewDataContainer());

            return htmlHelper;
        }

    }
}
