using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspnetmvcdemo.Models;

namespace aspnetmvcdemo.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            string[] courses = { "ASP.NET", "Python", "JavaEE", "C" };
            ViewBag.courses = courses;
            ViewBag.Trainer = "Srikanth Pragada";
            return View();
        }


        public ActionResult List()
        {
            CourseViewModel courses = new CourseViewModel();
            return View(courses);
        }

        public ActionResult Fee()
        {
            ViewBag.Course = "";
            return View();
        }
        [HttpPost]
        public ActionResult Fee(string course)
        {
            ViewBag.Course = course;
            if (course == "Python")
                ViewBag.Fee = 4000;
            else if (course == "Java")
                ViewBag.Fee = 5000;
            else
                ViewBag.Fee = 3500;

            return View();
        }

    }
}