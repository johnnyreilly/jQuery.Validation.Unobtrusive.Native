using System.Linq.Expressions;

namespace System.Web.Mvc.Html
{
    /// <summary>
    /// MVC HtmlHelper extension methods - extensions that make use of jQuery Validates native unobtrusive data validation properties
    /// </summary>
    public static class PasswordExtensions
    {
        /// <summary>
        /// Render a Password for the supplied model using native jQuery Validate Unobtrusive extensions (only if true passed)
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="useNativeUnobtrusiveAttributes">Pass true if you want to use native extensions</param>
        /// <param name="htmlAttributes">OPTIONAL</param>
        /// <returns></returns>
        public static IHtmlString PasswordFor<TModel, TProperty>(
          this HtmlHelper<TModel> htmlHelper,
          Expression<Func<TModel, TProperty>> expression,
          bool useNativeUnobtrusiveAttributes,
          object htmlAttributes = null)
        {
            // Return to native if true not passed
            if (!useNativeUnobtrusiveAttributes)
                return htmlHelper.PasswordFor(expression, htmlAttributes);

            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var attributes = Mapper.GetUnobtrusiveValidationAttributes(htmlHelper, expression, htmlAttributes, metadata);

            var password = Mapper.GenerateHtmlWithoutMvcUnobtrusiveAttributes(() =>
                htmlHelper.PasswordFor(expression, attributes));

            return password;
        }
    }
}
