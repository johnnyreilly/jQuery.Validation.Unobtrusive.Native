using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class RegularExpressionModel
    {
        [RegularExpression("^hello$")]
        public string RegularExpression { get; set; }
    }
}
