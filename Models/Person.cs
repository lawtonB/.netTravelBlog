using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TravelBlog.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int LocationId { get; set; }
        public int ExperienceId { get; set; }
        public virtual Location Location { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
