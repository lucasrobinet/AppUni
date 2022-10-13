using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppUni.Entities
{
    public class Usuario: EntityBase
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(50, MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public List<Role> Roles { get; set; }

    }
}
