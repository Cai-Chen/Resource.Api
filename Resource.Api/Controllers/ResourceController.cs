using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Resource.Api.Controllers
{
    [Route("resource")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        [Route("get")]
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(new { Name = "Cai Chen" });
        }
    }
}
