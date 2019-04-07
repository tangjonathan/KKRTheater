using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KKRTheater.ViewModels.Movies
{
    public class MovieIndexModel
    {
        public IEnumerable<MovieIndexListingModel> Movies { get; set; }
    }
}
