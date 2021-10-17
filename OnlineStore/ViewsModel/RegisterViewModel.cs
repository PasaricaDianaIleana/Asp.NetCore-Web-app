using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewsModel
{
    public class RegisterViewModel
    {
        [Required]
        [RegularExpression("^[A-Z][a-z]{2,15}$")]
        public string FirstName { get; set; }
        [RegularExpression("^[A-Z][a-z]{3,20}$")]
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Country { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber { get; set; }
     
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password", ErrorMessage ="Password and confirm password don't match")]
        public string ConfirmPassword { get; set; }
    }
}
