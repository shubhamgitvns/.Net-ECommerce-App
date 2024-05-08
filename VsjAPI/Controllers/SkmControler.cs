using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace VsjAPI.Controllers
{

    [ApiController]
    [Route("vsj/[controller]")]
    public class SkmControler:ControllerBase
    {
        private static readonly string[] names = {
            "Shubham", "shivam", "Sachin", "Akash"
        };
        int len = names.Length;
        [HttpGet]
        public System.Collections.Generic.IEnumerable<String> GetItems()
        {
            String[] s = new String[3];
            s[0] = "Name = Shubham";
            s[1] = "Class = 12";
            s[2] = "Age = 20";

            return s;
        }

    }
}
