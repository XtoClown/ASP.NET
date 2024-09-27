using lr_two.Services;
using Microsoft.AspNetCore.Mvc;

namespace lr_two.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController: ControllerBase
    {
        private readonly ITestService _controller;
        
        public TestController(ITestService controller)
        {
            this._controller = controller;
        }
        [HttpGet]
        public string Index()
        {
            return _controller.Send();
        }
    }
}
