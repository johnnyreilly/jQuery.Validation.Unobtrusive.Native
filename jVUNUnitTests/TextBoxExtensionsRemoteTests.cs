using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jQuery.Validation.Unobtrusive.Native.MVC.UnitTests
{
    /// <summary>
    /// FakeRemoteAttribute subclasses RemoteAttribute so that we can override GetUrl and return a fake URL string.  
    /// This is a much more straightforward way to unit test what we need of the remote attribute rather than getting into
    /// the seventh circle of hell mocking / faking up the relevant parts of HttpContext ( http://volaresystems.com/blog/post/dont-mock-httpcontext.aspx )
    /// </summary>
    public class FakeRemoteAttribute : RemoteAttribute
    {
        public FakeRemoteAttribute(string action, string controller) : base(action, controller)
        {
        }

        protected override string GetUrl(ControllerContext controllerContext)
        {
            return "Fake Url";
        }
    }


    [TestClass]
    public class TextBoxExtensionsRemoteTests
    {
        public class RemoteModel
        {
            [FakeRemote("RemoteAction", "Demo")]
            public string Remote { get; set; }
        }

        [TestMethod]
        public void TextBoxFor_creates_remote_data_attributes_for_string_with_Remote_attribute()
        {
            // Arrange
            var htmlHelper = HtmlHelperFactory.Create(new RemoteModel());

            // Act
            var result = TextBoxExtensions.TextBoxFor(htmlHelper, exampleModel => exampleModel.Remote, true);

            // Assert
            Assert.AreEqual("<input "+
                "data-msg-remote=\"&#39;Remote&#39; is invalid.\" "+
                "data-rule-remote=\"{"+
                "&quot;url&quot;:&quot;Fake Url&quot;,"+
                "&quot;additionalfields&quot;:&quot;*.Remote&quot;"+
                "}\" "+
                "id=\"Remote\" name=\"Remote\" type=\"text\" value=\"\" />", result.ToHtmlString());
        }

    }
}
