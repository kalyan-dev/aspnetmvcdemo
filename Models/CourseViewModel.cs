using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnetmvcdemo.Models
{
    public class CourseViewModel
    {
        public List<String> Courses;
        public string Trainer;

        public CourseViewModel()
        {
            this.Courses = new List<string> { "c#", "C", "Java", "ASP.NET MVC", "Python" };
            this.Trainer = "Srikanth";
        }

    }
}