using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class MaxLengthMinLengthModel
    {
        [StringLength(7)]
        public string MaxLength { get; set; }

        [StringLength(10, MinimumLength = 5)]
        public string MaxAndMinLength { get; set; }
    }
}