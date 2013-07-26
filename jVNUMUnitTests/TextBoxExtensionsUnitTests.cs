using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQueryValidateNativeUnobtrusiveMVCUnitTests
{
    [TestClass]
    public class TextBoxExtensionsUnitTests
    {
        private class RangeAndNumberModel
        {
            [Range(-20, 40)]
            public decimal RangeAndNumberDemo { get; set; }
        }

        /// <summary>
        /// Test for @Html.TextBoxFor(x => x.RangeAndNumberDemo, true)
        /// </summary>
        [TestMethod]
        public void TextBoxFor_has_range_and_number_data_attributes()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RangeAndNumberModel { RangeAndNumberDemo = 77 });

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.RangeAndNumberDemo, true);

            // Assert
            Assert.AreEqual("<input " +
                "data-msg-number=\"The field RangeAndNumberDemo must be a number.\" " +
                "data-msg-range=\"The field RangeAndNumberDemo must be between -20 and 40.\" " +
                "data-msg-required=\"The RangeAndNumberDemo field is required.\" " +
                "data-rule-number=\"true\" " +
                "data-rule-range=\"[-20,40]\" " +
                "data-rule-required=\"true\" " +
                "id=\"RangeAndNumberDemo\" name=\"RangeAndNumberDemo\" type=\"text\" value=\"\" />", 
                result.ToHtmlString());
        }

    }
}
