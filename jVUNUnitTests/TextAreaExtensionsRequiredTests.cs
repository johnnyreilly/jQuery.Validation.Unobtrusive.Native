using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextAreaExtensionsRequiredTests
    {
        private const string HTMLRequiredDate = "<textarea "+
                "cols=\"20\" "+
                "data-msg-date=\"The field Date must be a date.\" " +
                "data-msg-required=\"The Date field is required.\" "+
                "data-rule-date=\"true\" " +
                "data-rule-required=\"true\" "+
                "id=\"Date\" name=\"Date\" rows=\"2\">\r\n</textarea>";

        private class RequiredStringModel
        {
            [Required]
            public string String { get; set; }
        }

        [TestMethod]
        public void TextAreaFor_creates_required_data_attributes_for_string_with_Required_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredStringModel());

            // Act
            var result = TextAreaExtensionsUnobtrusive.TextAreaFor(htmlHelper, exampleModel => exampleModel.String, true);

            // Assert
            Assert.AreEqual("<textarea "+
                "cols=\"20\" "+
                "data-msg-required=\"The String field is required.\" "+
                "data-rule-required=\"true\" "+
                "id=\"String\" name=\"String\" rows=\"2\">\r\n</textarea>", result.ToHtmlString());
        }

        private class DateTimeModel
        {
            public DateTime Date { get; set; }
        }

        [TestMethod]
        public void TextAreaFor_creates_required_and_date_data_attributes_for_DateTime()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new DateTimeModel());

            // Act
            var result = TextAreaExtensionsUnobtrusive.TextAreaFor(htmlHelper, exampleModel => exampleModel.Date, true);

            // Assert
            Assert.AreEqual(HTMLRequiredDate, result.ToHtmlString());
        }

        private class RequiredNullableDateTimeModel
        {
            [Required]
            public DateTime? Date { get; set; }
        }

        [TestMethod]
        public void TextAreaFor_creates_required_and_date_data_attributes_for_nullable_DateTime_with_Required_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredNullableDateTimeModel());

            // Act
            var result = TextAreaExtensionsUnobtrusive.TextAreaFor(htmlHelper, exampleModel => exampleModel.Date, true);

            // Assert
            Assert.AreEqual(HTMLRequiredDate, result.ToHtmlString());
        }
    }
}
