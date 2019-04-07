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
    public class ActorServices : IActor
    {
        private TheaterContext _context;

        public ActorServices(TheaterContext context)
        {
            _context = context;
        }


        public void Save()
        {
            _context.SaveChanges();
        }
        public void Add(Actor newActor)
        {
            _context.Add(newActor);
            Save();
        }

        public void AddMovie(Actor actor, int movieId)
        {
            FilmCast newFilmCast = new FilmCast
            {
                ActorId = actor.Id,
                MovieId = movieId
            };
            actor.FilmCasts.Add(newFilmCast);
        }

        public void RemoveMovie(Actor actor, int movieId)
        {
            FilmCast updateFC = actor.FilmCasts.Where(filmCast => filmCast.MovieId == movieId).FirstOrDefault();
            Delete(updateFC);
        }

        public async Task<List<Actor>> GetAllLight()
        {
            return await _context.Actors
                .ToListAsync();
        }
        public async Task<List<Actor>> GetAll()
        {
            return await _context.Actors
                .Include(actor => actor.FilmCasts)
                .ThenInclude(filmCast => filmCast.Movie)
                .ToListAsync();
        }

        public async Task<Actor> GetById(int id)
        {
            return await _context.Actors
                .Include(actor => actor.FilmCasts)
                .ThenInclude(filmCast => filmCast.Movie)
             .FirstOrDefaultAsync(actor => actor.Id == id);
        }

        public async Task<Actor> GetByName(string name)
        {
            return await _context.Actors
                .Include(actor => actor.FilmCasts)
                .ThenInclude(filmCast => filmCast.Movie)
             .FirstOrDefaultAsync(actor => actor.Name == name);
        }

        public async Task<List<Movie>> GetMovies(int id)
        {
            Actor actor = await GetById(id);

            if (actor != null)
                return await actor.FilmCasts.ToAsyncEnumerable().Select
                    (filmCast => filmCast.Movie).ToList();

            else return null;
        }

        public void Delete(object deleteObj)
        {
            _context.Remove(deleteObj);
            _context.SaveChanges();
        }

    }
}
