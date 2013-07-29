using System;
using System.ComponentModel.DataAnnotations;

namespace jQueryValidateNativeUnobtrusive.Models
{
    public enum TriStateEnum
    {
        DontKnow = -1,
        No = 0,
        Yes = 1
    }

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

        public bool BoolDemo { get; set; }

        [Required]
        public TriStateEnum? RadioButtonRequiredDemo { get; set; }
    }
}