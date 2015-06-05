using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class MaxLengthMinLengthModel
    {
        [StringLength(7)]
        public string StringLengthMaxOnly { get; set; }

        [StringLength(10, MinimumLength = 5)]
        public string StringLengthMaxAndMinLength { get; set; }

        [MinLength(6)]
        public string MinLength { get; set; }

        [MaxLength(9)]
        public string MaxLength { get; set; }
    }
}