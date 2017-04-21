using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Controllers
{
    public class GummiesController : Controller
    {
        private GummiContext db = new GummiContext();
        public IActionResult Index()
        {
            return View(db.Gummies.ToList());
        }
        
        public IActionResult Details(int id)
        {
            var thisGummi = db.Gummies.FirstOrDefault(Gummies => Gummies.GummiId == id);
            return View(thisGummi);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Gummi gummi)
        {
            db.Gummies.Add(gummi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisGummi = db.Gummies.FirstOrDefault(gummies => gummies.GummiId == id);
            return View(thisGummi);
        }

        [HttpPost]
        public IActionResult Edit(Gummi gummi)
        {
            db.Entry(gummi).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisGummi = db.Gummies.FirstOrDefault(gummies => gummies.GummiId == id);
            return View(thisGummi);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisGummi = db.Gummies.FirstOrDefault(gummies => gummies.GummiId == id);
            db.Gummies.Remove(thisGummi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
