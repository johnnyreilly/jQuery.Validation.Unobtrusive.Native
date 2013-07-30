using System.Web.Mvc.Html;

namespace System.Web.Mvc
{
    public static class NavExtensions
    {
        public static IHtmlString RenderMenuItem(this HtmlHelper helper,
            string linkText, string actionName, string controllerName,
            object routeValues = null, object htmlAttributes = null)
        {
            //Determine current controller / action
            var rd = helper.ViewContext.RouteData;
            var currentController = rd.GetRequiredString("controller");
            var currentAction = rd.GetRequiredString("action");

            var li = new TagBuilder("li")
                {
                    InnerHtml = helper.ActionLink(linkText, actionName, controllerName, routeValues, htmlAttributes).ToString()
                };

            //Highlight selected item if required
            if (controllerName == currentController && actionName == currentAction) li.AddCssClass("active");

            return MvcHtmlString.Create(li.ToString(TagRenderMode.Normal));
        }
    }
}