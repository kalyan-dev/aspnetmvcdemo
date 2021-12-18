using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspnetmvcdemo.Models;

namespace aspnetmvcdemo.Controllers
{
    public class InterestController : Controller
    {
        // GET: Interest
        public ActionResult Index()
        {
            var m = new Interest();

            return View(m);
        }


        [HttpPost]
        public ActionResult Index(Interest model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.msg = model.amount * model.rate / 100;
                model.interest = model.amount * model.rate / 100;
            }
            return View(model);
        }

        public ActionResult Interest()
        {
            var m = new Interest();

            return View(m);
        }


        [HttpPost]
        public ActionResult Interest(Interest model)
        {
            if (ModelState.IsValid)
            {

                model.amount = model.amount * 2;
                model.rate = model.rate * 2;

                ViewBag.msg = model.amount * model.rate / 100;
                model.interest = model.amount * model.rate / 100;
            }
            return View(model);
        }

    }
}