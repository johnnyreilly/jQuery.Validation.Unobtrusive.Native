using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    [TestClass]
    public class EnumDropDownListExtensionsRequiredTests
    {
        private enum SomeValues
        {
           [Display(Name = "Value 1")]
           Value1 = 1,
           [Display(Name = "Value 2")]
           Value2 = 2
        }
        
        private class RequiredEnumModel
        {
           [Required]
           public SomeValues? RequiredEnum { get; set; }
        }

        [TestMethod]
        public void EnumDropDownListFor_creates_required_data_attributes_for_enum_with_Required_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RequiredEnumModel());
            
            // Act
            var result = EnumDropDownListExtensions.EnumDropDownListFor(htmlHelper, exampleModel => exampleModel.RequiredEnum, true);
            
            // Assert
            var expected = "<select data-msg-required=\"The RequiredEnum field is required.\" data-rule-required=\"true\" id=\"RequiredEnum\" name=\"RequiredEnum\">" +
               "<option selected=\"selected\" value=\"\"></option>\r\n" +
               "<option value=\"1\">Value 1</option>\r\n" +
               "<option value=\"2\">Value 2</option>\r\n" +
               "</select>";
            Assert.AreEqual(expected, result.ToHtmlString());
        }
    }
}
