using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class TooltipModel
    {
        [Required]
        public int? TextBox { get; set; }

        [Required]
        public string DropDownList { get; set; }
    }
}