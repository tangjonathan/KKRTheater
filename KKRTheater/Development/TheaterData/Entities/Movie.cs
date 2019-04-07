using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheaterData.Entities
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        public int Rank { get; set; }

        [Required]
        public string Title { get; set; }
        
        public string Description { get; set; }

        [Required]
        public int Year { get; set; }

        public int Runtime { get; set; }
        public decimal? Rating { get; set; }
        public decimal? Revenue { get; set; }
        public int? Metascore { get; set; }

        
        public virtual Director Director { get; set; }
        public virtual ICollection<FilmCast> FilmCasts { get; set; }
        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
