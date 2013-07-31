using System.Web.Mvc;

namespace jQuery.Validation.Unobtrusive.Native.Demos.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}