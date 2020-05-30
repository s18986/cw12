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
        public IActionResult GetDetails(Patients pat)
        {
            var db = new s18986Context();
            var Recepty = db.Prescriptions.ToList().Where(d => d.IdPatient == pat.IdPatient);
            ViewBag.Imie = pat.FirstName;
            return View(Recepty);
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