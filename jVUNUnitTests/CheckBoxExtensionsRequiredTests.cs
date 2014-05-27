using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class CheckBoxExtensionsRequiredTests
    {
        private class RequiredBoolModel
        {
            public bool Bool { get; set; }
        }

        [TestMethod]
        public void CheckBoxFor_creates_required_data_attributes_for_bool()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredBoolModel());

            // Act
            var result = CheckBoxExtensions.CheckBoxFor(htmlHelper, exampleModel => exampleModel.Bool, true);

            // Assert
            Assert.AreEqual("<input " +
                "data-msg-required=\"The Bool field is required.\" " +
                "data-rule-required=\"true\" " +
                "id=\"Bool\" name=\"Bool\" type=\"checkbox\" value=\"true\" />" +
                "<input name=\"Bool\" type=\"hidden\" value=\"false\" />", result.ToHtmlString());
        }

        [TestMethod]
        public void CheckBoxFor_creates_creates_required_and_custom_data_attributes_for_bool()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredBoolModel());

            // Act
            var result = CheckBoxExtensions.CheckBoxFor(htmlHelper, exampleModel => exampleModel.Bool, true, htmlAttributes: new { data_accounttypeid = "accounttype1" });

            // Assert
            Assert.AreEqual("<input " +
                "data-accounttypeid=\"accounttype1\" " +
                "data-msg-required=\"The Bool field is required.\" " +
                "data-rule-required=\"true\" " +
                "id=\"Bool\" name=\"Bool\" type=\"checkbox\" value=\"true\" />" +
                "<input name=\"Bool\" type=\"hidden\" value=\"false\" />", result.ToHtmlString());
        }
    }
}
