using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class TextBoxExtensionsRegexTests
    {
        private class RegexModel
        {
            [RegularExpression(".*")]
            public string RegularExpression { get; set; }
        }


        [TestMethod]
        public void TextBoxFor_creates_pattern_data_attributes_for_string_with_RegularExpression_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RegexModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.RegularExpression, true);

            // Assert
            Assert.AreEqual("<input " +
                "data-msg-pattern=\"The field RegularExpression must match the regular expression &#39;.*&#39;.\" " +
                "data-rule-pattern=\".*\" " +
                "id=\"RegularExpression\" name=\"RegularExpression\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

    }
}
