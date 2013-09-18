using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsEmailTests
    {
        private class EmailModel
        {
            [EmailAddress]
            public string Email { get; set; }
        }


        [TestMethod]
        public void TextBoxFor_creates_email_data_attributes_for_string_with_EmailAddress_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new EmailModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Email, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-email=\"The Email field is not a valid e-mail address.\" "+
                "data-rule-email=\"true\""+
                " id=\"Email\" name=\"Email\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

    }
}
