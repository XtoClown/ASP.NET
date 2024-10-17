using lr_eight.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr_eight.Controllers
{
    public class ProductController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<ProductViewModel> products = new List<ProductViewModel>();

            ProductViewModel product1 = new ProductViewModel { Id = 0, Name = "Meat", Price = 148.98, CreatedDate =DateTime.Now };
            ProductViewModel product2 = new ProductViewModel { Id = 1, Name = "Fish", Price = 200, CreatedDate = new DateTime(2024, 10, 12, 18, 30, 25) };
            ProductViewModel product3 = new ProductViewModel { Id = 2, Name = "Potato", Price = 50.25, CreatedDate = new DateTime(2025, 5, 12, 12, 30, 00) };
            ProductViewModel product4 = new ProductViewModel { Id = 3, Name = "Cucumber", Price = 70.60, CreatedDate = new DateTime(2026, 11, 14, 8, 8, 48) };
            ProductViewModel product5 = new ProductViewModel { Id = 4, Name = "Tomato", Price = 120, CreatedDate = new DateTime(2027, 12, 31, 23, 59, 59) };

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);

            return View(products);
        }
    }
}
