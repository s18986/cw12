using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zestaw12.Models;

namespace Zestaw12.Controllers
{
    public class PatientController : Controller
    {
        private readonly Models.s18986Context _DbContext;
        public PatientController(Models.s18986Context context)
        {
            _DbContext = context;
        }
        public IActionResult Index()
        {
            ViewBag.Nazwisko = "Kowalski";
            var res = _DbContext.Patients.ToList();
            return View(res);
        }
        public IActionResult GetPatients()
        {
            return View();
        }
        public IActionResult GetDetails(int id)
        {
            var db = new s18986Context();
            var pat = db.Patients.FirstOrDefault(d => d.IdPatient == id);
            return View(pat);
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
    }
}