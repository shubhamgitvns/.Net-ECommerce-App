using Microsoft.AspNetCore.Mvc;

namespace VsjAPI.Controllers
{

    [ApiController]
    [Route("vsj/[controller]")]
    public class ShubhamController:ControllerBase
    {

        [HttpGet]
        public string GetItems()
        {
            return "Shubham ";
        }
    }
}
