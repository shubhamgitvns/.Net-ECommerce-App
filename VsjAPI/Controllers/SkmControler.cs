using Microsoft.AspNetCore.Mvc;

namespace VsjAPI.Controllers
{

    [ApiController]
    [Route("vsj/[controller]")]
    public class SkmControler:ControllerBase
    {
        [HttpGet]
        public string GetItems()
        {
            return "This is new Controler";
        }
    }
}
