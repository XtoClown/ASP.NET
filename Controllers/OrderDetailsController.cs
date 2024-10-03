using lr_six.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace lr_six.Controllers
{
    [Route("OrderDetails")]
    public class OrderDetailsController: Controller
    {
        [HttpGet]
        public IActionResult OrderDetails()
        {
            int lenght = Int32.Parse(Request.Cookies["amountOfProducts"]);
            List<Product> model = new List<Product>(lenght);
            for(int i = 0; i < lenght; i++)
            {
                model.Add(new Product());
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult OrderDetails(List<Product> model)
        {
            if(ModelState.IsValid)
            {
                var serializedModel = JsonSerializer.Serialize(model);
                Response.Cookies.Append("serializedModel", serializedModel);
                return RedirectToAction("Result", "ResultOutput");
            }
            else
            {
                return View(model);
            }
        }
    }
}
