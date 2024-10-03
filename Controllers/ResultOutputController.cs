using lr_six.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace lr_six.Controllers
{
    [Route("Result")]
    public class ResultOutputController: Controller
    {
        [HttpGet]
        public ActionResult Result()
        {
            var serializedModel = Request.Cookies["serializedModel"];
            ViewBag.model = JsonSerializer.Deserialize<List<Product>>(serializedModel.ToString());
            ViewBag.username = Request.Cookies["username"];
            return View();
        }
    }
}
