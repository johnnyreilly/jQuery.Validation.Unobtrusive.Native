using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class CreditCardModel
    {
        [CreditCard]
        public string CreditCard { get; set; }
    }
}