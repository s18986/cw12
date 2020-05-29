using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zestaw12.Models;

namespace Zestaw12.Controllers
{
    public class DoctorsController : Controller
    {
        /// <summary>
        /// ponizej maja byc widoki
        /// </summary>
        /// <returns></returns>
        /// // kliknac addViec i elo
        private readonly Models.s18986Context _DbContext;
        public DoctorsController(Models.s18986Context context)
        {
            _DbContext = context;
        }
        public IActionResult Index()
        {
            ViewBag.Nazwisko = "Kowalski";
            var res = _DbContext.Doctors.ToList();
            return View(res);
        }
        public IActionResult GetDoctors()
        {
            return View();
        }
        public IActionResult GetDetails(int id)
        {
            var db = new s18986Context();
            var doc = db.Doctors.FirstOrDefault(d => d.Id == id);
            return View(doc);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctors doc)
        {
            if (!ModelState.IsValid)
            {
                return View(doc);
            }
            var db = new s18986Context();
            doc.Email = "hrh@.wp.pl";
            db.Doctors.Add(doc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}