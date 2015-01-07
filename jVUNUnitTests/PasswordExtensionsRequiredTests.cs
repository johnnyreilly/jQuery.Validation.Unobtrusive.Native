using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class PasswordExtensionsRequiredTests
    {
        private class RequiredStringModel
        {
            [Required]
            public string String { get; set; }
        }

        [TestMethod]
        public void PasswordFor_creates_required_data_attributes_for_string_with_Required_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredStringModel());

            // Act
            var result = PasswordExtensions.PasswordFor(htmlHelper, exampleModel => exampleModel.String, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-required=\"The String field is required.\" "+
                "data-rule-required=\"true\" "+
                "id=\"String\" name=\"String\" type=\"password\" />", result.ToHtmlString());
        }
    }
}
