using System.ComponentModel.DataAnnotations;

namespace Assignment_1.Models
{
    public class AddUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        //public string ConfirmPassword { get; set; }
    }
}
