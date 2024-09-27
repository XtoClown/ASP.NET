using lr_five.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace lr_five.Controllers
{
    [ApiController]
    [Route("CookieForm")]
    public class CookieFormController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromForm]FormCookieInputModel model)
        {
            Response.Cookies.Append("saveTextFromInput", model.TextFromInput);
            Response.Cookies.Append("saveDateFromInput", model.DateFromInput.ToString());
            return View();
        }
        [HttpGet("watch_cookie")]
        public IActionResult WatchCookie()
        {
            ViewBag.savedText = Request.Cookies["saveTextFromInput"];
            ViewBag.savedDate = Request.Cookies["saveDateFromInput"];
            return View();
        }
    }
}
