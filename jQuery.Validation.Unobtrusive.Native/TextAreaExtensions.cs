using System.Linq.Expressions;
using System.Web.Mvc.Html;

namespace System.Web.Mvc
{
    /// <summary>
    /// MVC HtmlHelper extension methods - extensions that make use of jQuery Validates native unobtrusive data validation properties
    /// </summary>
    public static class TextAreaExtensions
    {
        /// <summary>
        /// Render a TextArea for the supplied model using native jQuery Validate Unobtrusive extensions (only if true passed)
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="useNativeUnobtrusiveAttributes">Pass true if you want to use native extensions</param>
        /// <param name="rows">OPTIONAL</param>
        /// <param name="columns">OPTIONAL</param>
        /// <param name="htmlAttributes">OPTIONAL</param>
        /// <returns></returns>
        public static IHtmlString TextAreaFor<TModel, TProperty>(
          this HtmlHelper<TModel> htmlHelper,
          Expression<Func<TModel, TProperty>> expression,
          bool useNativeUnobtrusiveAttributes,
          int rows = 2,
          int columns = 20,
          object htmlAttributes = null)
        {
            // Return to native if true not passed
            if (!useNativeUnobtrusiveAttributes)
                return htmlHelper.TextAreaFor(expression, rows, columns, htmlAttributes);

            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var attributes = Mapper.GetUnobtrusiveValidationAttributes(htmlHelper, expression, htmlAttributes, metadata);

            return htmlHelper.TextArea(metadata.PropertyName, metadata.Model as string, rows, columns, attributes);
        }

    }
}
