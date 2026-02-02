using HEKStore.Application.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HEKStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet("success")]
        public IActionResult Success()
        {
            return Ok(ApiResponse<string>.SuccessResponse(
                "API çalışıyor 🚀"));
        }

        [HttpGet("error")]
        public IActionResult Error()
        {
            throw new Exception("Boom!");
        }
    }
}
