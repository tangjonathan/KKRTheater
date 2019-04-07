using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace KKRTheater.ViewModels.Movies
{
    public class MovieAddModel
    {
        public int Year { get; set; }
        public string Title { get; set; }
        public int DirectorId { get; set; }
        public int Runtime { get; set; }
        public decimal? Revenue { get; set; }
        public string Description { get; set; }

        public Director Director { get; set; }
    }
}
