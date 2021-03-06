﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace KKRTheater.ViewModels.Directors
{
    public class DirectorEditModel
    {   
        public int Id { get; set; }
        [MaxLength(255, ErrorMessage = "Too Long")]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Birthplace { get; set; }
        public string Bio { get; set; }
        public List<AssignedMovies> AssignedMovies { get; set; }
    }

    public class AssignedMovies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Assigned { get; set; }
    }
}
