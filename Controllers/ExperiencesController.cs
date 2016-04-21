using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TravelBlog.Models;
using Microsoft.AspNet.Mvc.Rendering;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class ExperiencesController : Controller
    {
        private TravelBlogDbContext db = new TravelBlogDbContext();
        public IActionResult Index()
        {
            return View(db.Experiences.ToList());
        }

        public IActionResult ExperienceToLocation(int id)
        {
            var ExperienceLocations = db.Locations.Where(x => x.LocationId == id);
            return View(ExperienceLocations);
        }

        public IActionResult Create(int id)
        {
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "LocationName");

            return View();
        }

        [HttpPost]
        public IActionResult Create (Experience experience)
        {
            db.Experiences.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
