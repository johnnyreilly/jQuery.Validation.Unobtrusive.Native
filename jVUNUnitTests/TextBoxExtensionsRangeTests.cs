using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsRangeTests
    {
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
        public void TextBoxFor_creates_range_required_and_number_data_attributes_for_short_with_Range_attribute()
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
        public void TextBoxFor_creates_range_required_and_number_data_attributes_for_int_with_Range_attribute()
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
        public void TextBoxFor_creates_range_required_and_number_data_attributes_for_long_with_Range_attribute()
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
        public void TextBoxFor_creates_range_required_and_number_data_attributes_for_byte_with_Range_attribute()
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
        public void TextBoxFor_creates_range_required_and_number_data_attributes_for_decimal_with_Range_attribute()
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
        public void TextBoxFor_creates_range_required_and_number_data_attributes_for_float_with_Range_attribute()
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
        public void TextBoxFor_creates_range_required_and_number_data_attributes_for_double_with_Range_attribute()
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
        public void TextBoxFor_creates_range_and_number_data_attributes_for_nullable_short_with_Range_attribute()
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
        public void TextBoxFor_creates_range_and_number_data_attributes_for_nullable_int_with_Range_attribute()
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
        public void TextBoxFor_creates_range_and_number_data_attributes_for_nullable_long_with_Range_attribute()
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
        public void TextBoxFor_creates_range_and_number_data_attributes_for_nullable_byte_with_Range_attribute()
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
        public void TextBoxFor_creates_range_and_number_data_attributes_for_decimal_with_Range_attribute()
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
        public void TextBoxFor_creates_range_and_number_data_attributes_for_float_with_Range_attribute()
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
        public void TextBoxFor_creates_range_and_number_data_attributes_for_double_with_Range_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new NullableDoubleRangeModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Number, true);

            // Assert
            Assert.AreEqual(HTMLRangeNumberWithFraction, result.ToHtmlString());
        }
    }
}
