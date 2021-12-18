using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspnetmvcdemo.Models;

namespace aspnetmvcdemo.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            ViewBag.Message = "Jai Shri Mataji";
            return View();
        }

        public ActionResult TodoList()
        {
            var lst = new TodoList(5);
            lst.addItem("aspnet mvc practice");
            lst.addItem("go to Beeramguda");
            lst.addItem("meditation");
            lst.addItem("sy notes for the day");

            return View(lst);
        }


        public ActionResult Greet(string f="Kalyan", string l="Chukka")
        {
            Person p = new Person { firstName = f, lastName = l };
            return View(p);
        }


        public ActionResult Interest2()
        {
            var model = new Interest2();
            return View(model);
        }

        [HttpPost]
        public ActionResult Interest2(Interest2 model)
        {
            if (ModelState.IsValid)
            {
                model.Result = model.Amount * model.Rate / 100;
            }

            return View(model);
        }

    }
}