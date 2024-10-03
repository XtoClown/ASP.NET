using System.ComponentModel.DataAnnotations;

namespace lr_six.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Please enter the quantity of goods you want to order...")]
        [Range(1, 5, ErrorMessage = "Error amount of products! Try entering a correct number...")]
        public int? AmountOfProductsFromInput { get; set; }
    }
}
