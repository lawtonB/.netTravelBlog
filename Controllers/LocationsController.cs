using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TravelBlog.Models;
using Microsoft.Data.Entity;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class LocationsController : Controller
    {
        private TravelBlogDbContext db = new TravelBlogDbContext();
        public IActionResult Index()
        {
            return View(db.Locations.Include(b => b.Persons).ToList());
        }

        public IActionResult LocationToExperience(int id)
        {
            var LocationExperiences = db.Experiences.Where(x => x.LocationId == id).ToList();
            return View(LocationExperiences);
        }
    }
}
