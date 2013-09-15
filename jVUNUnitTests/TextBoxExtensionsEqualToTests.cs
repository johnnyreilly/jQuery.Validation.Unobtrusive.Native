using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsEqualToTests
    {
        private class EqualToModel
        {
            public string MainField { get; set; }

            [System.ComponentModel.DataAnnotations.Compare("MainField", ErrorMessage = "Fields do not match.")]
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
                "data-msg-equalto=\"Fields do not match.\" "+
                "data-rule-equalto=\"#MainField\" "+
                "id=\"ConfirmField\" name=\"ConfirmField\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

    }
}
