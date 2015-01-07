using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsNumberTests
    {
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
    }
}
