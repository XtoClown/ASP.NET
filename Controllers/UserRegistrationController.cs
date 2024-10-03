using lr_six.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr_six.Controllers
{
    [Route("Registration")]
    [Route("")]
    public class UserRegistrationController: Controller
    {
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration([FromForm]User model)
        {
            if (ModelState.IsValid)
            {
                Response.Cookies.Append("username", model.UserNameFromInput);
                Response.Cookies.Append("password", model.UserPasswordFromInput);
                Response.Cookies.Append("years", model.UserYearsFromInput.ToString());
                return Redirect("Order");
            }
            else
            {
                return View(model);
            }
        }
    }
}
