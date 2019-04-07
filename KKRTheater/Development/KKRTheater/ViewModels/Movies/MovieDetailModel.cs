using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace KKRTheater.ViewModels.Movies
{
    public class MovieDetailModel
    {
        public int Id { get; set; }        
        public int Rank { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public DirectorListing Director { get; set; }
        public int Runtime { get; set; }
        public decimal? Revenue { get; set; }
        public int? Metascore { get; set; }
        public string Description { get; set; }
        public Dictionary<int,string> Actors { get; set; }
        public Dictionary<int, string> Genres { get; set; }
    }

    public class DirectorListing
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
