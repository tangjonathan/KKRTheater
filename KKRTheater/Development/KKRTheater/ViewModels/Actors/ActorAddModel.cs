using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace KKRTheater.ViewModels.Actors
{
    public class ActorAddModel
    {        
        [MaxLength(255, ErrorMessage = "Too Long")]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Birthplace { get; set; }
        public string Bio { get; set; }
    }
}
