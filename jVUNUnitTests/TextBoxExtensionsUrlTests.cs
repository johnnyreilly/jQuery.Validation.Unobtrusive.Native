using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsUrlTests
    {
        private class UrlModel
        {
            [Url]
            public string Url { get; set; }
        }


        [TestMethod]
        public void TextBoxFor_creates_url_data_attributes_for_string_with_Url_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new UrlModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Url, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-url=\"The Url field is not a valid fully-qualified http, https, or ftp URL.\" "+
                "data-rule-url=\"true\" "+
                "id=\"Url\" name=\"Url\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

    }
}
