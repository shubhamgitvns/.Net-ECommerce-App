using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace VsjAPI.Controllers
{
    public class StudentClass
    {
        public Int32 Id
        { get; set; }
        public String Name
        { get; set; }

        public String Collage
        { get; set; }

        public String Course
        { get; set; }

        public StudentClass(int id, string name, string collage, string course)
        {
            Id = id;
            Name = name;
            Collage = collage;
            Course = course;
        }

        public override string ToString()
        {
            return "Id=" + Id + ", " + "Name=" + Name + ", " + "Collage=" + Collage + "," + "Course="  + Course;
        }
    }
}
