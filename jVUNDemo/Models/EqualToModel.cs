using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class EqualToModel
    {
        [Required,
         EmailAddress]
        public string EMail { get; set; }

        [Compare("EMail", ErrorMessage = "Emails do not match.")]
        public string ConfirmEmail { get; set; }
    }
}