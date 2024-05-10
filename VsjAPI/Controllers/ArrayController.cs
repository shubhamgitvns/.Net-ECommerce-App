using Microsoft.AspNetCore.Mvc;
using System;

namespace VsjAPI.Controllers
{
    [ApiController]
    [Route("vsj/[controller]")]
    public class ArrayController : ControllerBase
    {
        [HttpGet]
        public System.Collections.Generic.IEnumerable<Person> GetItems()
        {

            Person[] p = new Person[3];
            p[0] = new Person("Shubham", "Varanasi", 20);
            p[1] = new Person("Akash", "Varanasi", 40);
           p[2] = new Person("join", "rom", 70);
            return p;
        }

       

    }
}
