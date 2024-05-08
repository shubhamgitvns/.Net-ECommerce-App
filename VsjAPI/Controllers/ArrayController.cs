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

            Person[] p = new Person[1];
            p[0] = new Person("Shubham", "Varanasi", 90);
            //p[0].Bookname="Dhoni";
               // p[1] = new Person("Computer", "Python", 990);
            //p[2] = new Person("Computer", "Python", 990);
            return p;
        }

       

    }
}
