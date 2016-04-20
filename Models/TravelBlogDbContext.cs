using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace TravelBlog.Models
{
    public class TravelBlogDbContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}
