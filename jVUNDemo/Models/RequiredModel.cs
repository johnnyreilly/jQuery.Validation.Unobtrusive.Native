using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class RequiredModel
    {
        [Required]
        public string TextBox { get; set; }

        [Required]
        public string DropDownList { get; set; }

        [Required]
        public string RadioButton { get; set; }

        [Required]
        public string TextArea { get; set; }
    }
}