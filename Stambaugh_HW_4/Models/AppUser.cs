using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Stambaugh_HW_4.Models
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        

    }
}
