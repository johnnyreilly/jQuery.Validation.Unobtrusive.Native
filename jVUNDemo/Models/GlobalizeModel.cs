using System;
using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class GlobalizeModel
    {
        [Range(10.5D, 20.3D)]
        public decimal Double { get; set; }

        [Required]
        public DateTime? DateTime { get; set; }
    }
}