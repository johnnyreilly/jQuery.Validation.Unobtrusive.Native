using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQueryValidateNativeUnobtrusiveMVCUnitTests
{
    [TestClass]
    public class TextBoxExtensionsHtmlAttributesTests
    {
        private class StringModel
        {
            public string String { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_custom_data_attributes()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new StringModel()); // used this model as it has few generated metadata attributes

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.String, true, htmlAttributes: new { data_test_attribute = "I am a test" });

            // Assert
            Assert.AreEqual("<input " +
                "data-test-attribute=\"I am a test\" " +
                "id=\"String\" name=\"String\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

        private class RequiredStringThatWillBeOverriddenModel
        {
            [Required]
            public string String { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_overrides_generated_data_attributes_with_custom_data_attributes()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredStringThatWillBeOverriddenModel()); // used this model as it has few generated metadata attributes

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.String, true, htmlAttributes: new { data_rule_required = "Yup", data_msg_required = "Uh-huh" });

            // Assert
            Assert.AreEqual("<input " +
                "data-msg-required=\"Uh-huh\" data-rule-required=\"Yup\" " +
                "id=\"String\" name=\"String\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }
    }
}
