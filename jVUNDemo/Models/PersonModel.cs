using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class PersonModel
    {
        [Display(Name = "First name"), 
         Required]
        public string FirstName { get; set; }

        [Display(Name = "Last name"), 
         Required]
        public string LastName { get; set; }
    }
}