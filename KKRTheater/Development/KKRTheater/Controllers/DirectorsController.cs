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
using KKRTheater.ViewModels.Directors;

namespace KKRTheater.Controllers
{
    public class DirectorsController : Controller
    {
        private IDirector _directors;
        private IMovie _movies;

        public DirectorsController(IDirector directors, IMovie movies)
        {
            _directors = directors;
            _movies = movies;
        }
        public async Task<IActionResult> Index()
        {
            ICollection<Director> directors = await _directors.GetAll();

            var listingResults = directors
                .Select(director => new DirectorIndexListingModel
                {
                    Id = director.Id,
                    Name = director.Name
                });

            var model = new DirectorIndexModel()
            {
                Directors = listingResults
            };

            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Director director = await _directors.GetById(id);

            if (director != null)
            {
                ICollection<Movie> movies = await _directors.GetMovies(id);
                var detailModel = new DirectorDetailModel
                {
                    Id = director.Id,
                    Name = director.Name,
                    Birthday = director.Birthday.Equals(DateTime.MinValue) ? "" : director.Birthday.ToString("MMMM dd yyyy"),
                    Birthplace = director.Birthplace,
                    Bio = director.Bio,
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
        public async Task<IActionResult> Add([Bind("Name")]Director director)
        {
            if (ModelState.IsValid)
            {
                Director foundDirector = await _directors.GetByName(director.Name);

                if (foundDirector == null)
                {
                    _directors.Add(director);
                    ModelState.Clear();
                    return RedirectToAction($"Detail/{director.Id}");
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


            Director foundDirector = await _directors.GetById(id);


            if (foundDirector != null)
            {
                DirectorEditModel viewModel = new DirectorEditModel();
                viewModel.Name = foundDirector.Name;
                viewModel.Id = foundDirector.Id;

                ICollection<Movie> linkedMovies = await _directors.GetMovies(foundDirector.Id);
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
        public async Task<IActionResult> Edit(DirectorEditModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Director foundDirector = await _directors.GetById(viewModel.Id);

                if (foundDirector != null)
                {
                    ICollection<Movie> linkedMovies = await _directors.GetMovies(foundDirector.Id);

                    foundDirector.Name = viewModel.Name;

                    foreach (AssignedMovies assignedMovie in viewModel.AssignedMovies)
                    {
                        if (assignedMovie.Assigned)
                            await _directors.AddMovie(foundDirector, assignedMovie.Id);

                        else if (linkedMovies.Select(movie => movie.Id).ToList().Contains(assignedMovie.Id))
                            await _directors.RemoveMovie(foundDirector, assignedMovie.Id);

                    }
                    _directors.Save();
                    ModelState.Clear();
                    return RedirectToAction($"Detail/{foundDirector.Id}");
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Director foundDirector = await _directors.GetById(id);
            if (foundDirector != null)
            {
                DirectorDeleteModel viewModel = new DirectorDeleteModel();
                viewModel.Id = foundDirector.Id;
                viewModel.Name = foundDirector.Name;

                return View(viewModel);
            }


            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Director foundDirector = await _directors.GetById(id);

            if (foundDirector != null)
            {
                _directors.Delete(foundDirector);
            }
            return RedirectToAction("Index");
        }
    }
}

