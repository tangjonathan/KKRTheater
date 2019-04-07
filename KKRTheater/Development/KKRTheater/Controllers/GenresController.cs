using KKRTheater.ViewModels.Genres;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterData;
using TheaterData.Entities;

namespace KKRTheater.Controllers
{
    public class GenresController : Controller
    {
        private IGenre _genres;

        public GenresController(IGenre genres)
        {
            _genres = genres;
        }

        public async Task<IActionResult> Index()
        {
            ICollection<Genre> genreModel = await _genres.GetAll();

            var listingResults = genreModel
                .Select(result => new GenreIndexListingModel
                {
                    Id = result.Id,
                    Name = result.Name
                });

            var model = new GenreIndexModel()
            {
                Genres = listingResults
            };

            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Genre genre = await _genres.GetById(id);

            if (genre != null)
            {
                ICollection<Movie> movies = await _genres.GetMovies(id);
                var detailModel = new GenreDetailModel
                {
                    Id = genre.Id,
                    Name = genre.Name,
                    Movies = movies
                        .Select(movie => new KeyValuePair<int, string>(movie.Id, movie.Title))
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                };

                return View(detailModel);
            }

            return NotFound();
        }
    }
}
