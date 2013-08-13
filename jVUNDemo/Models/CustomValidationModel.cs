using System.ComponentModel.DataAnnotations;
using jQuery.Validation.Unobtrusive.Native.Demos.CustomAttributes;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class CustomValidationModel
    {
        [Required]
        public string Property { get; set; }

        [Required,
         NotEqualTo("Property", ErrorMessage = "These fields cannot match")]
        public string DifferentProperty { get; set; }
    }
}