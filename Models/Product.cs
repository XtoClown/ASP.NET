using System.ComponentModel.DataAnnotations;

namespace lr_six.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Please enter the product name...")]
        [StringLength(50, MinimumLength = 7, ErrorMessage = "Please enter the correct product name...")]
        public string? ProductNameFromInput { get; set; }
        [Required(ErrorMessage = "Please enter the price...")]
        [Range(1, 300, ErrorMessage = "Please enter the correct price...")]
        public double? ProductPriceFromInput { get; set; }
    }
}
