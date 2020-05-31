using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW12.Models;
using Microsoft.AspNetCore.Mvc;

namespace CW12.Controllers
{
    public class PatientsController : Controller
    {
        private readonly s18986Context _context;
        public PatientsController(Models.s18986Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var temp = _context.Patients.ToList();
            return View(temp);
        }
        public IActionResult GetDetails(int id)
        {
            var db = new s18986Context();
            var pacjent = db.Patients.FirstOrDefault(d => d.IdPatient == id);
            return View(pacjent);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patients pat)
        {
            if (!ModelState.IsValid)
            {
                return View(pat);
            }
            var db = new s18986Context();
            db.Patients.Add(pat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public IActionResult Delete(Patients pat)
        {
            if (!ModelState.IsValid)
            {
                return View(pat);
            }
            var db = new s18986Context();
            db.Patients.Remove(pat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}