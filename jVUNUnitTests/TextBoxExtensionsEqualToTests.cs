using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsEqualToTests
    {
        private class EqualToModel
        {
            public string MainField { get; set; }

            [System.ComponentModel.DataAnnotations.Compare("MainField")]
            public string ConfirmField { get; set; }
        }


        [TestMethod]
        public void TextBoxFor_creates_equalto_data_attributes_for_string_with_Compare_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new EqualToModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.ConfirmField, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-equalto=\"&#39;ConfirmField&#39; and &#39;MainField&#39; do not match.\" " +
                "data-rule-equalto=\"#MainField\" "+
                "id=\"ConfirmField\" name=\"ConfirmField\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

    }
}
