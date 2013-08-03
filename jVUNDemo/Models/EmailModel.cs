using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class EmailModel
    {
        [EmailAddress]
        public string Email { get; set; }
    }
}