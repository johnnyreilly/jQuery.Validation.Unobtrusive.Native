using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Web.Mvc.Html
{
    /// <summary>
    /// MVC HtmlHelper extension methods - extensions that make use of jQuery Validates native unobtrusive data validation properties
    /// </summary>
    public static class DropDownListExtensions
    {
        /// <summary>
        /// Render a DropDownList for the supplied model using native jQuery Validate Unobtrusive extensions (only if true passed)
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="useNativeUnobtrusiveAttributes"></param>
        /// <param name="selectList"></param>
        /// <param name="optionLabel">OPTIONAL</param>
        /// <param name="htmlAttributes">OPTIONAL</param>
        /// <returns></returns>
        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            bool useNativeUnobtrusiveAttributes,
            IEnumerable<SelectListItem> selectList,
            string optionLabel = null,
            object htmlAttributes = null)
        {
            // Return to native if true not passed
            if (!useNativeUnobtrusiveAttributes)
                return htmlHelper.DropDownListFor(expression, selectList, optionLabel, htmlAttributes);

            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var attributes = Mapper.GetUnobtrusiveValidationAttributes(htmlHelper, expression, htmlAttributes, metadata);

            var dropDown = Mapper.GenerateHtmlWithoutMvcUnobtrusiveAttributes(() =>
                htmlHelper.DropDownListFor(expression, selectList, optionLabel, attributes));

            return dropDown;
        }
    }
}
