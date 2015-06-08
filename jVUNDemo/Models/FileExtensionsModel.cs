using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class FileExtensionsModel
    {
        // Note that this won't validate a HttpPostedFileBase - see http://stackoverflow.com/a/13650754/33051 for an example that will.
        [FileExtensions(Extensions = "txt,pdf")]
        public string FileExtensions { get; set; }
    }
}
