using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace System.Web.Mvc
{
    /// <summary>
    /// MVC HtmlHelper extension methods - extensions that make use of jQuery Validates native unobtrusive data validation properties
    /// </summary>
    public static class jQueryValidateNativeUnobtrusiveExtensions
    {
        private const string data_val_required = "data-val-required";
        private const string data_val_number = "data-val-number";
        private const string data_val_date = "data-val-date";
        private const string data_val_length = "data-val-length";
        private const string data_val_length_min = "data-val-length-min";
        private const string data_val_length_max = "data-val-length-max";
        private const string data_val_range = "data-val-range";

        /// <summary>
        /// Render a TextBox for the supplied model using native jQuery Validate Unobtrusive extensions (only if true passed)
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="useNativeUnobtrusiveAttributes">Pass true if you want to use native extensions</param>
        /// <param name="htmlAttributes">OPTIONAL</param>
        /// <returns></returns>
        public static IHtmlString TextBoxFor<TModel, TProperty>(
          this HtmlHelper<TModel> htmlHelper,
          Expression<Func<TModel, TProperty>> expression,
          bool useNativeUnobtrusiveAttributes,
          object htmlAttributes = null)
        {
            // Return to native if true not passed
            if (!useNativeUnobtrusiveAttributes)
                return htmlHelper.TextBoxFor(expression, htmlAttributes);

            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var attributes = GetUnobtrusiveValidationAttributes(htmlHelper, expression, htmlAttributes, metadata);

            return htmlHelper.TextBox(metadata.PropertyName, metadata.Model, attributes);
        }

        /// <summary>
        /// Render a DropDownList for the supplied model using native jQuery Validate Unobtrusive extensions (only if true passed)
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="useNativeUnobtrusiveAttributes"></param>
        /// <param name="selectList"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            bool useNativeUnobtrusiveAttributes,
            IEnumerable<SelectListItem> selectList,
            object htmlAttributes = null)
        {
            // Return to native if true not passed
            if (!useNativeUnobtrusiveAttributes)
                return htmlHelper.DropDownListFor(expression, selectList, htmlAttributes);

            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var attributes = GetUnobtrusiveValidationAttributes(htmlHelper, expression, htmlAttributes, metadata);

            return htmlHelper.DropDownList(metadata.PropertyName, selectList, attributes);
        }

        private static RouteValueDictionary GetUnobtrusiveValidationAttributes<TModel, TProperty>(HtmlHelper<TModel> helper,
                                                                                                  Expression<Func<TModel, TProperty>> expression,
                                                                                                  object htmlAttributes,
                                                                                                  ModelMetadata metadata)
        {
            var propertyName = helper.NameFor(expression).ToString();
            var unobtrusiveValidationAttributes = helper.GetUnobtrusiveValidationAttributes(propertyName, metadata);
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

            // Required
            if (unobtrusiveValidationAttributes.ContainsKey(data_val_required))
            {
                attributes.Add("data-rule-required", "true");
                attributes.Add("data-msg-required", unobtrusiveValidationAttributes[data_val_required]);
            }

            // Number
            if (unobtrusiveValidationAttributes.ContainsKey(data_val_number))
            {
                attributes.Add("data-rule-number", "true");
                attributes.Add("data-msg-number", unobtrusiveValidationAttributes[data_val_number]);
            }

            // Date
            if (unobtrusiveValidationAttributes.ContainsKey(data_val_date))
            {
                attributes.Add("data-rule-date", "true");
                attributes.Add("data-msg-date", unobtrusiveValidationAttributes[data_val_date]);
            }

            // Min and Max Length
            if (unobtrusiveValidationAttributes.ContainsKey(data_val_length))
            {
                if (unobtrusiveValidationAttributes.ContainsKey(data_val_length_min))
                {
                    attributes.Add("data-rule-minlength", unobtrusiveValidationAttributes[data_val_length_min]);
                    attributes.Add("data-msg-minlength", unobtrusiveValidationAttributes[data_val_length]);
                }

                if (unobtrusiveValidationAttributes.ContainsKey(data_val_length_max))
                {
                    attributes.Add("data-rule-maxlength", unobtrusiveValidationAttributes[data_val_length_max]);
                    attributes.Add("data-msg-maxlength", unobtrusiveValidationAttributes[data_val_length]);
                }
            }

            // Range
            // Driven from RangeAttribute eg "[Range(0, 100)]"
            if (unobtrusiveValidationAttributes.ContainsKey(data_val_range))
            {
                attributes.Add("data-rule-range",
                               string.Format("[{0},{1}]",
                                               unobtrusiveValidationAttributes["data-val-range-min"],
                                               unobtrusiveValidationAttributes["data-val-range-max"])
                    );
                attributes.Add("data-msg-range", unobtrusiveValidationAttributes[data_val_range]);
            }
            return attributes;
        }

    }
}
