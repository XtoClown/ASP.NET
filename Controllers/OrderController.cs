using lr_six.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr_six.Controllers
{
    [Route("Order")]
    public class OrderController: Controller
    {
        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Order([FromForm]Order model)
        {
            if (ModelState.IsValid)
            {
                Response.Cookies.Append("amountOfProducts", model.AmountOfProductsFromInput.ToString());
                return Redirect("OrderDetails");
            }
            else
            {
                return View(model);
            }
        }
    }
}
