using System.Linq.Expressions;
using System.Web.Mvc.Html;

namespace System.Web.Mvc
{
    /// <summary>
    /// MVC HtmlHelper extension methods - extensions that make use of jQuery Validates native unobtrusive data validation properties
    /// </summary>
    public static class CheckBoxExtensions
    {
        /// <summary>
        /// Render a CheckBox for the supplied model using native jQuery Validate Unobtrusive extensions (only if true passed).
        /// It's arguable whether this is necessary since a checkbox implicitly has a true / false value
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="useNativeUnobtrusiveAttributes">Pass true if you want to use native extensions</param>
        /// <param name="htmlAttributes">OPTIONAL</param>
        /// <returns></returns>
        public static IHtmlString CheckBoxFor<TModel>(this HtmlHelper<TModel> htmlHelper,
          Expression<Func<TModel, bool>> expression,
          bool useNativeUnobtrusiveAttributes,
          object htmlAttributes = null)
        {
            // Return to native if true not passed
            if (!useNativeUnobtrusiveAttributes)
                return htmlHelper.CheckBoxFor(expression, htmlAttributes);
            
            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var attributes = Mapper.GetUnobtrusiveValidationAttributes(htmlHelper, expression, htmlAttributes, metadata);

            var checkBox = Mapper.GenerateHtmlWithoutMvcUnobtrusiveAttributes(() =>
                htmlHelper.CheckBoxFor(expression, attributes));

            return checkBox;
        }

    }
}
