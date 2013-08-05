using System.Web.Mvc;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class RemoteModel
    {
        [Remote("RemoteSimple", "Demo")]
        public string Simple { get; set; }

        [Remote("RemoteServerErrorMessage", "Demo")]
        public string ServerErrorMessage { get; set; }
    }
}