using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQueryValidateNativeUnobtrusiveMVCUnitTests
{
    [TestClass]
    public class TextBoxExtensionsUnitTests
    {
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

        private class SingleModel { public float Number { get; set; } }

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

        private class NullableSingleModel { public float? Number { get; set; } }

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

        #region Range tests for @Html.TextBoxFor(x => x.Number, true)

        private const string HTMLRangeRequiredNumber = "<input " +
                                                       "data-msg-number=\"The field Number must be a number.\" " +
                                                       "data-msg-range=\"The field Number must be between -20 and 40.\" " +
                                                       "data-msg-required=\"The Number field is required.\" " +
                                                       "data-rule-number=\"true\" " +
                                                       "data-rule-range=\"[-20,40]\" " +
                                                       "data-rule-required=\"true\" " +
                                                       "id=\"Number\" name=\"Number\" type=\"text\" value=\"\" />";

        private const string HTMLRangeRequiredNumberWithFraction = "<input " +
                                                                   "data-msg-number=\"The field Number must be a number.\" " +
                                                                   "data-msg-range=\"The field Number must be between -20.5 and 40.3.\" " +
                                                                   "data-msg-required=\"The Number field is required.\" " +
                                                                   "data-rule-number=\"true\" " +
                                                                   "data-rule-range=\"[-20.5,40.3]\" " +
                                                                   "data-rule-required=\"true\" " +
                                                                   "id=\"Number\" name=\"Number\" type=\"text\" value=\"\" />";

        private const string HTMLRangeNumber = "<input " +
                                               "data-msg-number=\"The field Number must be a number.\" " +
                                               "data-msg-range=\"The field Number must be between -20 and 40.\" " +
                                               "data-rule-number=\"true\" " +
                                               "data-rule-range=\"[-20,40]\" " +
                                               "id=\"Number\" name=\"Number\" type=\"text\" value=\"\" />";

        private const string HTMLRangeNumberWithFraction = "<input " +
                                                           "data-msg-number=\"The field Number must be a number.\" " +
                                                           "data-msg-range=\"The field Number must be between -20.5 and 40.3.\" " +
                                                           "data-rule-number=\"true\" " +
                                                           "data-rule-range=\"[-20.5,40.3]\" " +
                                                           "id=\"Number\" name=\"Number\" type=\"text\" value=\"\" />";

        private class ShortRangeModel
        {
            [Range(typeof(short), "-20", "40")]
            public short Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_required_and_number_data_attributes_for_short_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new ShortRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeRequiredNumber, result.ToHtmlString());
        }

        private class IntRangeModel
        {
            [Range(-20, 40)]
            public int Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_required_and_number_data_attributes_for_int_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new IntRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeRequiredNumber, result.ToHtmlString());
        }

        private class LongRangeModel
        {
            [Range(typeof(long), "-20", "40")]
            public long Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_required_and_number_data_attributes_for_long_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new LongRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeRequiredNumber, result.ToHtmlString());
        }
        private class ByteRangeModel
        {
            [Range(typeof(byte), "20", "40")]
            public byte Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_required_and_number_data_attributes_for_byte_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new ByteRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeRequiredNumber.Replace("-20", "20"), result.ToHtmlString());
        }

        private class DecimalRangeModel
        {
            [Range(typeof(decimal), "-20.5", "40.3")]
            public decimal Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_required_and_number_data_attributes_for_decimal_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new DecimalRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeRequiredNumberWithFraction, result.ToHtmlString());
        }

        private class SingleRangeModel
        {
            [Range(typeof(float), "-20.5", "40.3")]
            public float Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_required_and_number_data_attributes_for_float_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new SingleRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeRequiredNumberWithFraction, result.ToHtmlString());
        }

        private class DoubleRangeModel
        {
            [Range(-20.5, 40.3)]
            public double Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_required_and_number_data_attributes_for_double_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new DoubleRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeRequiredNumberWithFraction, result.ToHtmlString());
        }

        private class NullableShortRangeModel
        {
            [Range(typeof(short), "-20", "40")]
            public decimal? Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_and_number_data_attributes_for_nullable_short_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableShortRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeNumber, result.ToHtmlString());
        }

        private class NullableIntRangeModel
        {
            [Range(-20, 40)]
            public int? Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_and_number_data_attributes_for_nullable_int_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableIntRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeNumber, result.ToHtmlString());
        }

        private class NullableLongRangeModel
        {
            [Range(typeof(long), "-20", "40")]
            public long? Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_and_number_data_attributes_for_nullable_long_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableLongRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeNumber, result.ToHtmlString());
        }

        private class NullableByteRangeModel
        {
            [Range(typeof(byte), "20", "40")]
            public byte? Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_and_number_data_attributes_for_nullable_byte_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableByteRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeNumber.Replace("-20", "20"), result.ToHtmlString());
        }

        private class NullableDecimalRangeModel
        {
            [Range(typeof(decimal), "-20.5", "40.3")]
            public decimal? Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_and_number_data_attributes_for_decimal_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableDecimalRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeNumberWithFraction, result.ToHtmlString());
        }

        private class NullableSingleRangeModel
        {
            [Range(typeof(float), "-20.5", "40.3")]
            public float? Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_and_number_data_attributes_for_float_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableSingleRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeNumberWithFraction, result.ToHtmlString());
        }

        private class NullableDoubleRangeModel
        {
            [Range(-20.5, 40.3)]
            public float? Number { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_range_and_number_data_attributes_for_double_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableDoubleRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeNumberWithFraction, result.ToHtmlString());
        }

        #endregion

        #region MaxLength / MinLength tests for @Html.TextBoxFor(x => x.String, true)

        private class MaxLengthModel
        {
            [StringLength(7)]
            public string MaxLength { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_maxlength_data_attributes_for_string_with_StringLength_attribute()
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
        public void TextBoxFor_has_maxlength_and_minlength_data_attributes_for_string_with_StringLength_attribute()
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
        #endregion

        #region HtmlAttributes tests for @Html.TextBoxFor(x => x.Number, true, htmlAttributes: new { data_test_attribute = "I am a test" })

        private class StringModel
        {
            public string String { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_has_custom_data_attributes()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new StringModel()); // used this model as it has few generated metadata attributes

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.String, true, htmlAttributes: new { data_test_attribute = "I am a test" });

            // Assert
            Assert.AreEqual("<input "+
                "data-test-attribute=\"I am a test\" "+
                "id=\"String\" name=\"String\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

        #endregion
    }
}
