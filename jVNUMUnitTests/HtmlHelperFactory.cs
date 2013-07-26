using System.Web.Mvc;

namespace jQueryValidateNativeUnobtrusiveMVCUnitTests
{
    public static class HtmlHelperFactory
    {
        internal static HtmlHelper<T> Create<T>(T model)
        {
            var vc = new ViewContext
                {
                    HttpContext = new FakeHttpContext(),
                    UnobtrusiveJavaScriptEnabled = true,
                    ClientValidationEnabled = true,
                    ViewData = new ViewDataDictionary(model)
                };

            var htmlHelper = new HtmlHelper<T>(vc, new FakeViewDataContainer());

            return htmlHelper;
        }

    }
}
