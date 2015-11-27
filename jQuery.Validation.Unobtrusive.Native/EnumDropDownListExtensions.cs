using System.Linq.Expressions;

namespace System.Web.Mvc.Html
{
    /// <summary>
    /// MVC HtmlHelper extension methods - extensions that make use of jQuery Validates native unobtrusive data validation properties
    /// </summary>
    public static class EnumDropDownListExtensions
    {
        /// <summary>
        /// Render a DropDownList for the supplied model using native jQuery Validate Unobtrusive extensions (only if true passed)
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="useNativeUnobtrusiveAttributes"></param>
        /// <param name="optionLabel">OPTIONAL</param>
        /// <param name="htmlAttributes">OPTIONAL</param>
        /// <returns></returns>
        public static IHtmlString EnumDropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            bool useNativeUnobtrusiveAttributes,
            string optionLabel = null,
            object htmlAttributes = null)
        {
            // Return to native if true not passed
            if (!useNativeUnobtrusiveAttributes)
                return htmlHelper.EnumDropDownListFor(expression, optionLabel, htmlAttributes);

            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var attributes = Mapper.GetUnobtrusiveValidationAttributes(htmlHelper, expression, htmlAttributes, metadata);

            var dropDown = Mapper.GenerateHtmlWithoutMvcUnobtrusiveAttributes(() =>
                htmlHelper.EnumDropDownListFor(expression, optionLabel, attributes));

            return dropDown;
        }
    }
}
