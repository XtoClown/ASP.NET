using lr_four.Services;
using Microsoft.AspNetCore.Mvc;

namespace lr_four.Controllers
{
    [ApiController]
    [Route("Library")]
    public class LibraryController
    {
        private readonly ILibraryService _service;
        public LibraryController(ILibraryService service)
        {
            _service = service;
        }
        [HttpGet]
        public string Greeting()
        {
            return $"{_service.Greeting()}";
        }
        [HttpGet("Books")]
        public string Books()
        {
            return $"{_service.GetBookList()}";
        }
        [HttpGet("Profile")]
        public string Profile()
        {
            return $"{_service.GetUserInfo()}";
        }
        [HttpGet("Profile/{id:int?}")]
        public string Profile(int id)
        {
            if(id == null)
            {
                return $"{_service.GetUserInfo()}";
            }
            else
            {
                if ( id <= 5 && id >= 0)
                {
                    return $"{_service.GetUserInfo(id)}";
                }
                else return "Error";
            }
        }
    }
}
