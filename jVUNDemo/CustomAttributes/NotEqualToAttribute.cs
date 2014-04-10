using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;

namespace jQuery.Validation.Unobtrusive.Native.Demos.CustomAttributes
{
    public class NotEqualToAttribute : ValidationAttribute, IClientValidatable
    {
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule
            {
                ErrorMessage = ErrorMessage,
                ValidationType = "notequalto"
            };
            rule.ValidationParameters["other"] = "#" + OtherProperty; // CSS Selector (won't work if applied to nested properties on a viewmodel)
            yield return rule;
        }

        public string OtherProperty { get; private set; }

        public NotEqualToAttribute(string otherProperty)
        {
            OtherProperty = otherProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(OtherProperty);
            if (property == null)
            {
                return new ValidationResult(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        "{0} is unknown property",
                        OtherProperty
                    ), new [] { validationContext.MemberName }
                );
            }
            var otherValue = property.GetValue(validationContext.ObjectInstance, null);
            if (value == otherValue)
            {
                return new ValidationResult(
                    FormatErrorMessage(validationContext.DisplayName), 
                    new [] { validationContext.MemberName });
            }
            return ValidationResult.Success;
        }
    }
}