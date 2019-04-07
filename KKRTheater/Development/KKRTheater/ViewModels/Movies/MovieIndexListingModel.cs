using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace KKRTheater.ViewModels.Movies
{
    public class MovieIndexListingModel
    {
        public int Id { get; set; }        
        public int Rank { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public decimal? Revenue { get; set; }
    }
}
