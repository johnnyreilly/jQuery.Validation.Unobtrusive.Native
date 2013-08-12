using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;

namespace jQuery.Validation.Unobtrusive.Native.Demos.CustomAttributes
{
    public class NotEqualAttribute : ValidationAttribute, IClientValidatable
    {
        public string OtherProperty { get; private set; }
        public bool Test { get; private set; }

        public NotEqualAttribute(string otherProperty, bool test)
        {
            OtherProperty = otherProperty;
            Test = test;
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
                    )
                );
            }
            var otherValue = property.GetValue(validationContext.ObjectInstance, null);
            if (object.Equals(value, otherValue))
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return null;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule
            {
                ErrorMessage = ErrorMessage,
                ValidationType = "notequalto",
            };
            rule.ValidationParameters["other"] = OtherProperty;
            rule.ValidationParameters["test"] = Test;
            yield return rule;
        }
    }
}