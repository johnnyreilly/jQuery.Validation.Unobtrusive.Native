using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQueryValidateNativeUnobtrusiveMVCUnitTests
{
    [TestClass]
    public class TextBoxExtensionsDateTests
    {
        public const string HTMLRequiredDate = "<input " +
                                                  "data-msg-date=\"The field Date must be a date.\" " +
                                                  "data-msg-required=\"The Date field is required.\" " +
                                                  "data-rule-date=\"true\" " +
                                                  "data-rule-required=\"true\" " +
                                                  "id=\"Date\" name=\"Date\" type=\"text\" value=\"\" />";

        private class DateTimeModel { public DateTime Date { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_required_and_date_data_attributes_for_DateTime()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new DateTimeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Date, true);

            // Assert
            Assert.AreEqual(HTMLRequiredDate, result.ToHtmlString());
        }

        private const string HTMLDate = "<input " +
                                        "data-msg-date=\"The field Date must be a date.\" " +
                                        "data-rule-date=\"true\" " +
                                        "id=\"Date\" name=\"Date\" type=\"text\" value=\"\" />";

        private class NullableDateTimeModel { public DateTime? Date { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_date_data_attributes_for_nullable_DateTime()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableDateTimeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Date, true);

            // Assert
            Assert.AreEqual(HTMLDate, result.ToHtmlString());
        }
    }
}
