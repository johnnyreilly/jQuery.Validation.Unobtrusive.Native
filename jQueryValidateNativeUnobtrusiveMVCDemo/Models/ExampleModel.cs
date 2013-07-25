using System;
using System.ComponentModel.DataAnnotations;

namespace jQueryValidateNativeUnobtrusive.Models
{
    public class ExampleModel
    {
        [Required]
        public DateTime? RequiredDateDemo { get; set; }

        [Required, 
         StringLength(10, MinimumLength=5)]
        public string StringLengthAndRequiredDemo { get; set; }

        [Range(-20,40)]
        public decimal RangeAndNumberDemo { get; set; }

        [Required]
        public string DropDownRequiredDemo { get; set; }
    }
}