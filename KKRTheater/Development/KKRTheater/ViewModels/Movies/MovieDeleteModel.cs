﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace KKRTheater.ViewModels.Movies
{
    public class MovieDeleteModel
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }
        public int Runtime { get; set; }
        public decimal? Revenue { get; set; }
        public string Description { get; set; }

        public Director Director { get; set; }

        public ICollection<string> Actors { get; set; }
        public ICollection<string> Genres { get; set; }
    }
}
