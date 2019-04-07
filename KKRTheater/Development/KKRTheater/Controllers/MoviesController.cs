using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KKRTheater.ViewModels;
using KKRTheater.ViewModels.Movies;
using TheaterData;
using TheaterData.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KKRTheater.Controllers
{
    public class MoviesController : Controller
    {
        private IMovie _movies;
        private IDirector _directors;
        private IActor _actors;
        private IGenre _genres;

        public MoviesController(IMovie movies, IDirector directors, IActor actors, IGenre genres)
        {
            _movies = movies;
            _directors = directors;
            _actors = actors;
            _genres = genres;
        }
        public async Task<IActionResult> Index()
        {
            ICollection<Movie> movieModels = await _movies.GetAllLight();

            var listingResults = movieModels
                .Select(result => new MovieIndexListingModel
                {
                    Id = result.Id,
                    Rank = result.Rank,
                    Year = result.Year,
                    Title = result.Title,
                    Revenue = result.Revenue
                });

            var model = new MovieIndexModel()
            {
                Movies = listingResults
            };

            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Movie movie = await _movies.GetById(id);
            if (movie != null)
            {
                ICollection<Actor> actors = await _movies.GetActors(movie.Id);
                ICollection<Genre> genres = await _movies.GetGenres(movie.Id);


                var detailModel = new MovieDetailModel
                {
                    Id = movie.Id,
                    Rank = movie.Rank,
                    Title = movie.Title,
                    Year = movie.Year,
                    Director = new DirectorListing() { Id = movie.Director.Id, Name = movie.Director.Name },
                    Runtime = movie.Runtime,
                    Revenue = movie.Revenue,
                    Metascore = movie.Metascore,
                    Description = movie.Description,
                    Actors = actors
                        .Select(actor => new KeyValuePair<int, string>(actor.Id, actor.Name))
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
                    Genres = genres
                        .Select(genre => new KeyValuePair<int, string>(genre.Id, genre.Name))
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                };

                return View(detailModel);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            await PopulateDirectorDropDownList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(MovieAddModel viewModel)
        {
            Director foundDirector = await _directors.GetById(viewModel.DirectorId);

            if (ModelState.IsValid)
            {
                Movie newMovie = new Movie
                {
                    Title = viewModel.Title,
                    Director = foundDirector,
                    Description = viewModel.Description,
                    Year = viewModel.Year,
                    Runtime = viewModel.Runtime,
                    Revenue = viewModel.Revenue
                };
                newMovie.Title = viewModel.Title;

                _movies.Add(newMovie);
                ModelState.Clear();
                return RedirectToAction($"Detail/{newMovie.Id}");
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id, string actorSearchName = "")
        {
            //Avoid Null Exception when no search filter passed.
            if (string.IsNullOrEmpty(actorSearchName))
                actorSearchName = "";

            Movie foundMovie = await _movies.GetById(id);


            if (foundMovie != null)
            {
                MovieEditModel viewModel = new MovieEditModel
                {
                    Title = foundMovie.Title,
                    Id = foundMovie.Id,
                    Year = foundMovie.Year,
                    Revenue = foundMovie.Revenue,
                    Runtime = foundMovie.Runtime,
                    Description = foundMovie.Description,
                    Director = foundMovie.Director
                };

                //Build List of Actors
                ICollection<Actor> linkedActors = foundMovie.FilmCasts.Select(filmCast => filmCast.Actor).ToList();
                ICollection<Actor> allActors = await _actors.GetAllLight();

                List<AssignedEntity> assignedActors = allActors.OrderBy(actor => actor.Name).Where(actor => actor.Name.Contains(actorSearchName))
                    .Select(actor => new AssignedEntity
                    {
                        Id = actor.Id,
                        Name = actor.Name,
                        Assigned = linkedActors.Contains(actor)
                    }).ToList();


                viewModel.AssignedActors = assignedActors;


                //Build List of Genres  
                ICollection<Genre> linkedGenres = foundMovie.MovieGenres.Select(movieGenre => movieGenre.Genre).ToList();
                ICollection<Genre> allGenres = await _genres.GetAllLight();

                viewModel.AssignedGenres = allGenres
                    .Select(genre => new AssignedEntity
                    {
                        Id = genre.Id,
                        Name = genre.Name,
                        Assigned = linkedGenres.Contains(genre)
                    }).ToList();


                await PopulateDirectorDropDownList(foundMovie.Director.Id);
                return View(viewModel);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MovieEditModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Movie foundMovie = await _movies.GetById(viewModel.Id);

                if (foundMovie != null)
                {
                    Director foundDirector = await _directors.GetById(viewModel.DirectorId);

                    if (foundDirector != null)
                        foundMovie.Director = foundDirector;

                    if (!string.IsNullOrEmpty(viewModel.Title))
                        foundMovie.Title = viewModel.Title;
                    if (!string.IsNullOrEmpty(viewModel.Description))
                        foundMovie.Description = viewModel.Description;
                    if (viewModel.Year > 0)
                        foundMovie.Year = viewModel.Year;
                    if (viewModel.Runtime > 0)
                        foundMovie.Runtime = viewModel.Runtime;
                    if (viewModel.Revenue > 0)
                        foundMovie.Revenue = viewModel.Revenue;

                    foreach (AssignedEntity assignedActor in viewModel.AssignedActors)
                    {
                        if (assignedActor.Assigned)
                            _movies.AddActor(foundMovie, assignedActor.Id);

                        else if (foundMovie.FilmCasts.Select(filmCast => filmCast.ActorId).ToList().Contains(assignedActor.Id))
                            _movies.RemoveActor(foundMovie, assignedActor.Id);

                    }

                    foreach (AssignedEntity assignedGenre in viewModel.AssignedGenres)
                    {
                        if (assignedGenre.Assigned)
                            _movies.AddGenre(foundMovie, assignedGenre.Id);

                        else if (foundMovie.MovieGenres.Select(movieGenre => movieGenre.GenreId).ToList().Contains(assignedGenre.Id))
                            _movies.RemoveGenre(foundMovie, assignedGenre.Id);
                    }

                    _movies.Save();
                    ModelState.Clear();
                    return RedirectToAction($"Detail/{foundMovie.Id}");
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Movie foundMovie = await _movies.GetById(id);
            if (foundMovie != null)
            {
                ICollection<Actor> actors = await _movies.GetActors(foundMovie.Id);
                ICollection<Genre> genres = await _movies.GetGenres(foundMovie.Id);

                MovieDeleteModel viewModel = new MovieDeleteModel()
                {

                    Id = foundMovie.Id,
                    Title = foundMovie.Title,
                    Year = foundMovie.Year,
                    DirectorName = foundMovie.Director.Name,
                    Runtime = foundMovie.Runtime,
                    Revenue = foundMovie.Revenue,
                    Description = foundMovie.Description,
                    Actors = actors
                    .Select(actor => actor.Name).ToList(),
                    Genres = genres
                    .Select(genre => genre.Name).ToList()
                };

                return View(viewModel);
            }

            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Movie foundMovie = await _movies.GetById(id);

            if (foundMovie != null)
            {
                _movies.Delete(foundMovie);
            }
            return RedirectToAction("Index");
        }

        private async Task PopulateDirectorDropDownList(object selectedDirector = null)
        {
            ICollection<Director> allDirectors = await _directors.GetAll();
            ViewBag.DirectorId = new SelectList(allDirectors, "Id", "Name", selectedDirector);
        }
    }
}

