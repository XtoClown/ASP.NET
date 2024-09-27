using lr_three.Services;
using Microsoft.AspNetCore.Mvc;

namespace lr_three.Controllers
{
    [ApiController]
    [Route("time")]
    public class DayTimeServiceController
    {
        private readonly IDayTimeInfo _service;
        public DayTimeServiceController(IDayTimeInfo service)
        {
            _service = service;
        }
        [HttpGet]
        public string Index()
        {
            return _service.Info();
        }
    }
}
