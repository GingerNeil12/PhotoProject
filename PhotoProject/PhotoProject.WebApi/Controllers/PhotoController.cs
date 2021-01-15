using Microsoft.AspNetCore.Mvc;

namespace PhotoProject.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhotoController : ControllerBase
    {
        public PhotoController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok("HELLO IS IT ME YOUR LOOKING FOR");
        }
    }
}
