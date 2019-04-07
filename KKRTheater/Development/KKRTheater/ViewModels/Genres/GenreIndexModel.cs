using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KKRTheater.ViewModels.Genres
{
    public class GenreIndexModel
    {
        public IEnumerable<GenreIndexListingModel> Genres { get; set; }
    }
}
