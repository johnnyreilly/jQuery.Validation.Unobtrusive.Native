using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsFileExtensionsTests
    {
        private class ExtensionModel
        {
            [FileExtensions(Extensions = "doc,pdf,txt")]
            public string FileExtension { get; set; }
        }


        [TestMethod]
        public void TextBoxFor_creates_pattern_data_attributes_for_string_with_RegularExpression_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new ExtensionModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.FileExtension, true);

            // Assert
            Assert.AreEqual("<input " +
                "data-msg-extension=\"The FileExtension field only accepts files with the following extensions: .doc, .pdf, .txt\" " +
                "data-rule-extension=\"doc,pdf,txt\" " +
                "id=\"FileExtension\" name=\"FileExtension\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

    }
}
