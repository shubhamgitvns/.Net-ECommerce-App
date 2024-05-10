using Microsoft.AspNetCore.Mvc;

namespace VsjAPI.Controllers
{
    [ApiController]
    [Route("vsj/[controller]")]
    public class HelloWorldControllers
    {
        [HttpGet]
        public string GetItems()
        {
            return "Hello World";
        }

    }
}
