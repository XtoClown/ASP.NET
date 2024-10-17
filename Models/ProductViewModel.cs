using System.ComponentModel.DataAnnotations;

namespace lr_eight.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
