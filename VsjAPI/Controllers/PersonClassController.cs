using System;

namespace VsjAPI.Controllers
{

    public class Person
    {
        String name, city;
        int age;
        public String Name
        { get; set; }

        public String City
        { get; set; }

        public int Age
        { get; set; }




        public Person(string name, string city, int age)
        {
            this.Name = name;
            this.City = city;
            this.Age = age;
        }

        public override string? ToString()
        {
            return "Name=" + Name + ", " + "City=" + City + ", " + "Age=" + Age;
        }
    }
    public class PersonClassController
    {
    }
}
