using System.ComponentModel.DataAnnotations;

namespace lr_seven.Models
{
    public class FileGetModel
    {
        [Required(ErrorMessage = "Please enter your First Name...")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter correct First Name...")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Last Name...")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter correct Last Name...")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter File Name...")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter correct File Name...")]
        public string FileName { get; set; }
    }
}
