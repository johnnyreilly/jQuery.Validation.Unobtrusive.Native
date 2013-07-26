using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQueryValidateNativeUnobtrusiveMVCUnitTests
{
    [TestClass]
    public class TextBoxExtensionsUnitTests
    {
        /*
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
        */

        #region Number tests for @Html.TextBoxFor(x => x.Number, true)

        private const string HTMLRequiredNumber = "<input " +
                                                  "data-msg-number=\"The field Number must be a number.\" " +
                                                  "data-msg-required=\"The Number field is required.\" " +
                                                  "data-rule-number=\"true\" " +
                                                  "data-rule-required=\"true\" " +
                                                  "id=\"Number\" name=\"Number\" type=\"text\" value=\"\" />";

        private class ShortModel { public short Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_and_required_data_attributes_for_short()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new ShortModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRequiredNumber, result.ToHtmlString());
        }

        private class IntModel { public int Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_and_required_data_attributes_for_int()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new IntModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRequiredNumber, result.ToHtmlString());
        }

        private class LongModel { public long Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_and_required_data_attributes_for_long()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new LongModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRequiredNumber, result.ToHtmlString());
        }

        private class ByteModel { public byte Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_and_required_data_attributes_for_byte()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new ByteModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRequiredNumber, result.ToHtmlString());
        }

        private class DecimalModel { public decimal Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_and_required_data_attributes_for_decimal()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new DecimalModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRequiredNumber, result.ToHtmlString());
        }

        private class SingleModel { public Single Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_and_required_data_attributes_for_Single()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new SingleModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRequiredNumber, result.ToHtmlString());
        }

        private class DoubleModel { public double Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_and_required_data_attributes_for_double()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new DoubleModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRequiredNumber, result.ToHtmlString());
        }

        private const string HTMLNumber = "<input " +
                                          "data-msg-number=\"The field Number must be a number.\" " +
                                          "data-rule-number=\"true\" " +
                                          "id=\"Number\" name=\"Number\" type=\"text\" value=\"\" />";

        private class NullableShortModel { public short? Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_data_attribute_for_nullable_short()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableShortModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLNumber, result.ToHtmlString());
        }

        private class NullableIntModel { public int? Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_data_attributes_for_nullable_int()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableIntModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLNumber, result.ToHtmlString());
        }

        private class NullableLongModel { public long? Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_data_attributes_for_nullable_long()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableLongModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLNumber, result.ToHtmlString());
        }

        private class NullableByteModel { public byte? Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_data_attributes_for_nullable_byte()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableByteModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLNumber, result.ToHtmlString());
        }

        private class NullableDecimalModel { public decimal? Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_data_attributes_for_nullable_decimal()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableDecimalModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLNumber, result.ToHtmlString());
        }

        private class NullableSingleModel { public Single? Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_data_attributes_for_nullable_Single()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableSingleModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLNumber, result.ToHtmlString());
        }

        private class NullableDoubleModel { public double? Number { get; set; } }

        [TestMethod]
        public void TextBoxFor_creates_number_data_attributes_for_nullable_double()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableDoubleModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLNumber, result.ToHtmlString());
        }

        #endregion

        #region Date tests for @Html.TextBoxFor(x => x.Date, true)

        private const string HTMLRequiredDate = "<input " +
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

        #endregion

        #region Required tests for @Html.TextBoxFor(x => x.SomeProp, true)

        private const string HTMLRequiredString = "<input " +
                                                  "data-msg-required=\"The String field is required.\" " +
                                                  "data-rule-required=\"true\" " +
                                                  "id=\"String\" name=\"String\" type=\"text\" value=\"\" />";

        private class RequiredStringModel
        {
            [Required]
            public string String { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_required_data_attributes_for_string_with_Required_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredStringModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.String, true);

            // Assert
            Assert.AreEqual(HTMLRequiredString, result.ToHtmlString());
        }

        private class RequiredDateTimeModel
        {
            [Required]
            public DateTime Date { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_required_and_date_data_attributes_for_DateTime_with_Required_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredDateTimeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Date, true);

            // Assert
            Assert.AreEqual(HTMLRequiredDate, result.ToHtmlString());
        }

        private class RequiredNullableDateTimeModel
        {
            [Required]
            public DateTime? Date { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_required_and_date_data_attributes_for_nullable_DateTime_with_Required_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredNullableDateTimeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Date, true);

            // Assert
            Assert.AreEqual(HTMLRequiredDate, result.ToHtmlString());
        }
        
        #endregion

    }
}
