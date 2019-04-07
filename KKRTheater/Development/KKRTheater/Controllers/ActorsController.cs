using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KKRTheater.ViewModels;
using KKRTheater.ViewModels.Actors;
using TheaterData;
using TheaterData.Entities;
using Microsoft.Extensions.Logging;

namespace KKRTheater.Controllers
{
    public class ActorsController : Controller
    {
        private IActor _actors;
        private ILogger<ActorsController> _logger;
        private IMovie _movies;

        public ActorsController(IActor actors, IMovie movies, ILogger<ActorsController> logger)
        {
            _actors = actors;
            _movies = movies;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            ICollection<Actor> actorModel = await _actors.GetAll();

            var listingResults = actorModel
                .Select(result => new ActorIndexListingModel
                {
                    Id = result.Id,
                    Name = result.Name
                });

            var model = new ActorIndexModel()
            {
                Actors = listingResults
            };

            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Actor actor = await _actors.GetById(id);

            if (actor != null)
            {
                List<Movie> movies = await _actors.GetMovies(id);
                var detailModel = new ActorDetailModel
                {
                    Id = actor.Id,
                    Name = actor.Name,
                    Birthday = actor.Birthday.Equals(DateTime.MinValue) ? "" : actor.Birthday.ToString("MMMM dd yyyy"),
                    Birthplace = actor.Birthplace,
                    Bio = actor.Bio,
                    Movies = movies
                        .Select(movie => new KeyValuePair<int, string>(movie.Id, movie.Title))
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                };
                return View(detailModel);
            }

            return NotFound();
            
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([Bind("Name,Birthday,Birthplace,Bio")]Actor actor)
        {
            if (ModelState.IsValid)
            {
                Actor foundActor = await _actors.GetByName(actor.Name);

                if (foundActor == null)
                {
                    _actors.Add(actor);
                    ModelState.Clear();
                    ViewBag.UserMessage = "Actor Added";
                    return RedirectToAction($"Detail/{actor.Id}");
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id, string movieTitle = "")
        {
            //Avoid Null Exception when no search filter passed.
            if (movieTitle == null)
                movieTitle = "";

            Actor foundActor = await _actors.GetById(id);

            if (foundActor != null)
            {
                ActorEditModel viewModel = new ActorEditModel();
                viewModel.Name = foundActor.Name;
                viewModel.Id = foundActor.Id;

                ICollection<Movie> linkedMovies = foundActor.FilmCasts.Select(filmCast => filmCast.Movie).ToList();
                ICollection<Movie> allMovies = await _movies.GetAllLight();

                List<AssignedMovies> assignedMovies = allMovies.OrderBy(movie => movie.Title).Where(movie => movie.Title.Contains(movieTitle))
                    .Select(movie => new AssignedMovies
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        Assigned = linkedMovies.Contains(movie)
                    }).ToList();


                viewModel.AssignedMovies = assignedMovies;

                return View(viewModel);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ActorEditModel actorEditModel)
        {
            if (ModelState.IsValid)
            {
                Actor foundActor = await _actors.GetById(actorEditModel.Id);

                if (foundActor != null)
                {
                    foundActor.Name = actorEditModel.Name;

                    foreach (AssignedMovies assignedMovie in actorEditModel.AssignedMovies)
                    {
                        if (assignedMovie.Assigned)
                            _actors.AddMovie(foundActor, assignedMovie.Id);

                        else if (foundActor.FilmCasts.Select(filmCast => filmCast.MovieId).ToList().Contains(assignedMovie.Id))
                            _actors.RemoveMovie(foundActor, assignedMovie.Id);

                    }
                    _actors.Save();
                    ModelState.Clear();
                    return RedirectToAction($"Detail/{foundActor.Id}");
                }
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Actor foundActor = await _actors.GetById(id);
            if (foundActor != null)
            {
                ActorDeleteModel viewModel = new ActorDeleteModel();
                viewModel.Id = foundActor.Id;
                viewModel.Name = foundActor.Name;

                return View(viewModel);
            }

            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Actor foundActor = await _actors.GetById(id);

            if (foundActor != null)
            {
                _actors.Delete(foundActor);
            }
            return RedirectToAction("Index");
        }
    }
}
