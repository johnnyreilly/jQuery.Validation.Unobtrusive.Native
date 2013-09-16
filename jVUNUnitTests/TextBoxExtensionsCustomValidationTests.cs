using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    /// <summary>
    /// Custom attribute used only for testing purposes
    /// </summary>
    public class CustomAttribute : ValidationAttribute, IClientValidatable
    {
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule
            {
                ErrorMessage = ErrorMessage,
                ValidationType = "notequalto"
            };
            rule.ValidationParameters["other"] = "#" + OtherProperty;
            yield return rule;
        }

        public string OtherProperty { get; private set; }

        public CustomAttribute(string otherProperty)
        {
            OtherProperty = otherProperty;
        }

    }
    [TestClass]
    public class TextBoxExtensionsCustomValidationTests
    {
        public class CustomValidationModel
        {
            public string Property { get; set; }

            [Custom("Property", ErrorMessage = "These fields cannot match")]
            public string DifferentProperty { get; set; }
        }


        [TestMethod]
        public void TextBoxFor_creates_custom_validation_data_attributes_for_string_with_custom_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new CustomValidationModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.DifferentProperty, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-notequalto=\"These fields cannot match\" "+
                "data-rule-notequalto=\"{&quot;other&quot;:&quot;#Property&quot;}\" "+
                "id=\"DifferentProperty\" name=\"DifferentProperty\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

    }
}
