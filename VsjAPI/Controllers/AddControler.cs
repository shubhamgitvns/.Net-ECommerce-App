using Microsoft.AspNetCore.Mvc;
using System;

namespace VsjAPI.Controllers
{
    [ApiController]
    [Route("vsj/[controller]")]
    public class AddControler
    {
        [HttpGet]
        public String GetITems()
        {
            Int32 a = 10;
            Int32 b = 20;
            return "" + (a+b);

        }

    }
}
