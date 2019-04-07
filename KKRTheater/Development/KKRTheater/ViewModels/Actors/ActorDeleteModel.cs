using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace KKRTheater.ViewModels.Actors
{
    public class ActorDeleteModel
    {        
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
