using Microsoft.AspNetCore.Mvc;
using System;

namespace VsjAPI.Controllers
{
    //Define the Api rootes//
    [ApiController]
    [Route("vsj/[controller]")]
    public class ArrayController : ControllerBase
    {
        [HttpGet]
        public System.Collections.Generic.IEnumerable<Person> GetItems()
        {

            Person[] p = new Person[3];
            //p[0] = new Person("Shubham", "Varanasi", 20);
          
            return p;
        }

       

    }
}
