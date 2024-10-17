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

            ProductViewModel product1 = new ProductViewModel { Id = 0, Name = "FDSFSD", Price = 14.88, CreatedDate =DateTime.Now };
            ProductViewModel product2 = new ProductViewModel { Id = 2, Name = "FSDFSD", Price = 14.88, CreatedDate = DateTime.Now };
            ProductViewModel product3 = new ProductViewModel { Id = 3, Name = "SDF", Price = 14.88, CreatedDate = DateTime.Now };
            ProductViewModel product4 = new ProductViewModel { Id = 4, Name = "GFDGFD", Price = 14.88, CreatedDate = DateTime.Now };
            ProductViewModel product5 = new ProductViewModel { Id = 5, Name = "FDGDFG", Price = 14.88, CreatedDate = DateTime.Now };

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);

            return View(products);
        }
    }
}
