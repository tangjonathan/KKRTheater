using System;
using System.Collections.Generic;
using System.Text;

namespace TheaterData.Entities
{
    public class FilmCast
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Actor Actor { get; set; }
    }
}
