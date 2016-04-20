using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TravelBlog.Models;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class PersonsController : Controller
    {
        private TravelBlogDbContext db = new TravelBlogDbContext();
        public IActionResult Index()
        {
            return View(db.Persons.ToList());
        }
    
        public IActionResult PersonExperience(int id)
        {
            var PersonExperiences = db.Experiences.Where(x => x.ExperienceId == id).ToList();
            return View(PersonExperiences);
        }

        public IActionResult PersonLocation(int id )
        {
            var locationResult = db.Locations.Where(x => x.LocationId == id);
            return View(locationResult);
        }
    }
}
