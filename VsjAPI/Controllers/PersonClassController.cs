using System;

namespace VsjAPI.Controllers
{

    public class Person
    {
        public Int32 Id
        { get; set; }
        public String Name
        { get; set; }

        public String City
        { get; set; }

        public String Address
        { get; set; }




        public Person(int id, string name, string city,  string address)
        {
            this.Id = id;
            this.Name = name;
            this.City = city;
            this.Address = address;
        }

        public override string? ToString()
        {
            return "Id=" + Id + "," + "Name=" + Name + ", " + "City=" + City + ", " + "Address=" + Address;
        }
    }
    public class PersonClassController
    {
    }
}
