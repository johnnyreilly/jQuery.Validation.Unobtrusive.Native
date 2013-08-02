using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class UrlModel
    {
        [Url]
        public string Url { get; set; }
    }
}