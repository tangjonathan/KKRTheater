using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace KKRTheater.ViewModels.Genres
{
    public class GenreDetailModel
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public Dictionary<int,string> Movies { get; set; }
    }
}
