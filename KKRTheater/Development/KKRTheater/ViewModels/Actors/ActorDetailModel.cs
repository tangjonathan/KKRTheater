using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace KKRTheater.ViewModels.Actors
{
    public class ActorDetailModel
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Birthplace { get; set; }
        public string Bio { get; set; }
        public Dictionary<int,string> Movies { get; set; }
    }
}
