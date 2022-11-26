using Microsoft.AspNetCore.Mvc;

namespace Traceko.Web.Api.Controllers
{
    public class ApiController : ControllerBase
    {
        [HttpGet]
        [Route("api/hello-async")]
        public async Task<IActionResult> HelloAsync()
        {
            await Task.Delay(500);
            return Ok($"Hello async. Timestamp {DateTime.Now}");
        }

        [HttpGet]
        [Route("api/hello")]
        public IActionResult Hello()
        {
            return Ok($"Hello. Timestamp {DateTime.Now}");
        }
    }
}
