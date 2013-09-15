using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQueryValidateNativeUnobtrusiveMVCUnitTests
{
    [TestClass]
    public class TextBoxExtensionsMaxLengthMinLengthTests
    {
        private class MaxLengthModel
        {
            [StringLength(7)]
            public string MaxLength { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_maxlength_data_attributes_for_string_with_StringLength_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new MaxLengthModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.MaxLength, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-maxlength=\"The field MaxLength must be a string with a maximum length of 7.\" " +
                "data-rule-maxlength=\"7\" " +
                "id=\"MaxLength\" name=\"MaxLength\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

        private class MaxAndMinLengthModel
        {
            [StringLength(10, MinimumLength = 5)]
            public string MaxAndMinLength { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_maxlength_and_minlength_data_attributes_for_string_with_StringLength_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new MaxAndMinLengthModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.MaxAndMinLength, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-maxlength=\"The field MaxAndMinLength must be a string with a minimum length of 5 and a maximum length of 10.\" "+
                "data-msg-minlength=\"The field MaxAndMinLength must be a string with a minimum length of 5 and a maximum length of 10.\" "+
                "data-rule-maxlength=\"10\" "+
                "data-rule-minlength=\"5\" "+
                "id=\"MaxAndMinLength\" name=\"MaxAndMinLength\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }
    }
}
