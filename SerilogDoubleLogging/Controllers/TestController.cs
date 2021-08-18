using System;
using Microsoft.AspNetCore.Mvc;

namespace SerilogDoubleLogging.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        {
        }

        [HttpGet]
        [Route("")]
        public IActionResult Test()
        {
            throw new Exception("Test");
        }

        [HttpGet]
        [Route("error")]
        public IActionResult Error()
        {
            return new JsonResult(new { message= "There was an error with your request." });
        }
    }
}
