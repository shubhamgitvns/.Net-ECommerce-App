using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VsjAPI.Controllers
{
[ApiController]
[Route("vsj/[controller]")]
       public class ItemsController : ControllerBase
    {
        [HttpGet]
        public string GetItems()
        {
            return "A list of items";
        }
        [HttpGet("{id}")]
        public string GetItem(int id)
        {
            return "A single item " + id;
        }
}
}
