using System.Linq.Expressions;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace System.Web.Mvc
{
    /// <summary>
    /// MVC HtmlHelper extension methods - extensions that make use of jQuery Validates native unobtrusive data validation properties
    /// </summary>
    public static class Mapper
    {
        private const string data_val_required = "data-val-required";
        private const string data_val_number = "data-val-number";
        private const string data_val_date = "data-val-date";
        private const string data_val_length = "data-val-length";
        private const string data_val_length_min = "data-val-length-min";
        private const string data_val_length_max = "data-val-length-max";
        private const string data_val_range = "data-val-range";

        public static RouteValueDictionary GetUnobtrusiveValidationAttributes<TModel, TProperty>(HtmlHelper<TModel> helper,
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
            // Driven from StringLengthAttribute eg "[StringLength(10, MinimumLength=5)]"
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
