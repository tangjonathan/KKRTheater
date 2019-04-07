using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheaterData.Entities
{
    public class Actor 
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Birthplace { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<FilmCast> FilmCasts { get; set; }
    }
}
