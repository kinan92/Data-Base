using Data_Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Data_Base.Controllers
{
    public class HomeController : Controller
    {
        PeopleDbContext db = new PeopleDbContext();

        // GET: Home
        public ActionResult Index()
        {
            List<Person> myList = db.people.ToList();

            return View(myList);
        }

        public ActionResult Create()
        {
            Person me = new Person();
            me.Name = "Bobbo";
            me.Age = 99;

            db.people.Add(me); //Add Bobbo to the Data Base
            db.SaveChanges();   // Saves The changes (add Bobbo)


            return RedirectToAction("Index");
        }

    }
}