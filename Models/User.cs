using System.ComponentModel.DataAnnotations;

namespace lr_six.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please enter your name...")]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Please enter a username that is more than 3 characters long and less than 32 characters...")]
        public string? UserNameFromInput { get; set; }
        [Required(ErrorMessage = "Please enter your password...")]
        [StringLength(32, MinimumLength = 16, ErrorMessage = "Please enter a password longer than 16 characters and shorter than 32 characters...")]
        public string? UserPasswordFromInput { get; set; }
        [Required(ErrorMessage = "Please enter the number of your years...")]
        [Range(16, 150, ErrorMessage = "Error in the number of years! Try entering a correct number...")]
        public int? UserYearsFromInput { get; set; }
    }
}
