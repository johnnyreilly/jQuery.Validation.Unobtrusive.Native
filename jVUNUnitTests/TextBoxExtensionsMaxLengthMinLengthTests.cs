using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsMaxLengthMinLengthTests
    {
        private class StringLengthOnlyMaxModel
        {
            [StringLength(7)]
            public string MaxLength { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_maxlength_data_attributes_for_string_with_StringLength_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new StringLengthOnlyMaxModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.MaxLength, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-maxlength=\"The field MaxLength must be a string with a maximum length of 7.\" " +
                "data-rule-maxlength=\"7\" " +
                "id=\"MaxLength\" name=\"MaxLength\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

        private class StringLengthOnlyMinModel
        {
            [StringLength(int.MaxValue, MinimumLength = 6)]
            public string MinLength { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_minlength_data_attributes_for_string_with_StringLength_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new StringLengthOnlyMinModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.MinLength, true);

            // Assert
            Assert.AreEqual("<input " +
                "data-msg-minlength=\"The field MinLength must be a string with a minimum length of 6 and a maximum length of 2147483647.\" " +
                "data-rule-minlength=\"6\" " +
                "id=\"MinLength\" name=\"MinLength\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

        private class StringLengthWithMaxMinLengthModel
        {
            [StringLength(10, MinimumLength = 5)]
            public string MaxAndMinLength { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_maxlength_and_minlength_data_attributes_for_string_with_StringLength_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new StringLengthWithMaxMinLengthModel());

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

        private class MinLengthModel
        {
            [MinLength(6)]
            public string MinLength { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_minlength_data_attributes_for_string_with_MinLength_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new MinLengthModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.MinLength, true);

            // Assert
            Assert.AreEqual("<input " +
                "data-msg-minlength=\"The field MinLength must be a string or array type with a minimum length of &#39;6&#39;.\" " +
                "data-rule-minlength=\"6\" " +
                "id=\"MinLength\" name=\"MinLength\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

        private class MaxLengthModel
        {
            [MaxLength(10)]
            public string MaxLength { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_maxlength_data_attributes_for_string_with_MaxLength_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new MaxLengthModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.MaxLength, true);

            // Assert
            Assert.AreEqual("<input " +
                "data-msg-maxlength=\"The field MaxLength must be a string or array type with a maximum length of &#39;10&#39;.\" " +
                "data-rule-maxlength=\"10\" " +
                "id=\"MaxLength\" name=\"MaxLength\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }
    }
}
