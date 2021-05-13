using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Resource.Api.Services;
using System.Threading.Tasks;

namespace Resource.Api.Controllers
{
    [Route("resource")]
    [ApiController]
    [Authorize]
    public class ResourceController : ControllerBase
    {
        private readonly IDogServiceProvider _dogServiceProvider;

        public ResourceController(IDogServiceProvider dogServiceProvider)
        {
            _dogServiceProvider = dogServiceProvider;
        }

        [Route("get")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _dogServiceProvider.GetDogMessageAsync();
            return Ok(result);
        }
    }
}
