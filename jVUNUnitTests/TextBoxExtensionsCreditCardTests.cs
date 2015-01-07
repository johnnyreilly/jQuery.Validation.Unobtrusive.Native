using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsCreditCardTests
    {
        private class CreditCardModel
        {
            [CreditCard]
            public string CreditCard { get; set; }
        }


        [TestMethod]
        public void TextBoxFor_creates_creditcard_data_attributes_for_string_with_CreditCard_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new CreditCardModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.CreditCard, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-creditcard=\"The CreditCard field is not a valid credit card number.\" "+
                "data-rule-creditcard=\"true\" "+
                "id=\"CreditCard\" name=\"CreditCard\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

    }
}
