using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheaterData;
using TheaterData.Entities;

namespace TheaterServices
{
    public class MovieServices : IMovie
    {
        private TheaterContext _context;

        public MovieServices(TheaterContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Add(Movie newAsset)
        {
            _context.Add(newAsset);
            Save();
        }

        public async Task<ICollection<Movie>> GetAllLight()
        {
            return await _context.Movies
                .OrderBy(movie => movie.Title)
                .ToListAsync();
        }

        public async Task<ICollection<Movie>> GetAll()
        {
            return await _context.Movies
                .Include(movie => movie.Director)
                .Include(movie => movie.FilmCasts)
                    .ThenInclude(filmCast => filmCast.Actor)
                .Include(movie => movie.MovieGenres)
                    .ThenInclude(movieGenre => movieGenre.Genre)
                .OrderBy(movie => movie.Title)
                .ToListAsync();
        }

        public async Task<Movie> GetById(int id)
        {
            return await _context.Movies
                .Include(movie => movie.Director)
                .Include(movie => movie.FilmCasts)
                    .ThenInclude(filmCast => filmCast.Actor)
                .Include(movie => movie.MovieGenres)
                    .ThenInclude(movieGenre => movieGenre.Genre)
                .FirstOrDefaultAsync(movie => movie.Id == id);
        }

        public async Task<Movie> GetByTitle(string title)
        {
            return await _context.Movies
                .Include(movie => movie.Director)
                .Include(movie => movie.FilmCasts)
                    .ThenInclude(filmCast => filmCast.Actor)
                .Include(movie => movie.MovieGenres)
                    .ThenInclude(movieGenre => movieGenre.Genre)
             .FirstOrDefaultAsync(movie => movie.Title == title);
        }

        public void AddActor(Movie movie, int actorId)
        {
            FilmCast newFilmCast = new FilmCast
            {
                ActorId = actorId,
                MovieId = movie.Id
            };
            movie.FilmCasts.Add(newFilmCast);
        }

        public void RemoveActor(Movie movie, int actorId)
        {
            FilmCast updateFC = movie.FilmCasts.Where(filmCast => filmCast.ActorId == actorId).FirstOrDefault();
            Delete(updateFC);
        }

        public void AddDirector(Movie movie, Director director)
        {
            movie.Director = director;
            Save();
        }

        public void AddGenre(Movie movie, int genreId)
        {
            MovieGenre movieGenre = new MovieGenre
            {
                GenreId = genreId,
                MovieId = movie.Id
            };
            movie.MovieGenres.Add(movieGenre);
        }

        public void RemoveGenre(Movie movie, int genreId)
        {
            MovieGenre updateFC = movie.MovieGenres.Where(movieGenre => movieGenre.GenreId == genreId).FirstOrDefault();
            Delete(updateFC);
        }

        public async Task<ICollection<Actor>> GetActors(int id)
        {
            Movie movie = await GetById(id);

            if (movie != null)
                return await movie.FilmCasts.ToAsyncEnumerable().Select
                    (filmCast => filmCast.Actor).OrderBy(actor => actor.Name).ToList();
            else return null;

        }

        public async Task<ICollection<Genre>> GetGenres(int id)
        {
            Movie movie = await GetById(id);

            if (movie != null)
                return await movie.MovieGenres.ToAsyncEnumerable().Select
                    (movieGenre => movieGenre.Genre).ToList();
            else return null;

        }

        public void Delete(object deleteObj)
        {
            _context.Remove(deleteObj);
            _context.SaveChanges();
        }

    }
}
