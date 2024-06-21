using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace VsjAPI.Controllers
{
    [ApiController]
    [Route("vsj/[controller]")]
    public class result : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("Student Data");
        }

        [HttpGet("{name}")]
        public IActionResult GetItems(string name)
        {
            List<Person> people = new List<Person>
            {
                new Person(1, "Shubham", "Varanasi", "Pilikothi"),
                new Person(2, "Akash", "Varanasi", "TaktakPur"),
                new Person(3, "Chicku", "Varanasi", "Pandaypur"),
                new Person(4, "Shubham", "Varanasi", "Jaitpura")
            };

            if (name == "shubham")
            {
                // Returning both entries for "Shubham"
                return Ok(new List<Person> { people[0], people[3] });
            }
            if (name.ToLower() == "akash")
            {
                return Ok(people[1]);
            }
            if (name.ToLower() == "chicku")
            {
                return Ok(people[2]);
            }

            return Ok(people);

        }
    }

 
}
