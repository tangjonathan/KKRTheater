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

    public class DirectorServices : IDirector
    {
        private TheaterContext _context;

        public DirectorServices(TheaterContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Add(Director newDirector)
        {
            _context.Add(newDirector);
            _context.SaveChanges();
        }

        public async Task<ICollection<Director>> GetAll()
        {
            return await _context.Directors.OrderBy(director => director.Name).ToListAsync();
        }

        public async Task<Director> GetById(int id)
        {
            return await _context.Directors
             .FirstOrDefaultAsync(director => director.Id == id);
        }

        public async Task<Director> GetByName(string name)
        {
            return await _context.Directors
             .FirstOrDefaultAsync(director => director.Name == name);
        }

        public async Task<ICollection<Movie>> GetMovies(int id)
        {
            Director foundDirector = await GetById(id);

            if (foundDirector != null)
                return await _context.Movies.Where(movie => movie.Director == foundDirector).OrderBy(movie => movie.Title).ToListAsync();

            else return null;
        }

        public async Task AddMovie(Director director, int movieId)
        {
            Movie foundMovie = await _context.Movies.Where(movie => movie.Id == movieId).FirstOrDefaultAsync();

            if (foundMovie != null)
            {
                foundMovie.Director = director;
                Save();
            }
        }

        public async Task RemoveMovie(Director director, int movieId)
        {
            Movie foundMovie = await _context.Movies.Where(movie => movie.Id == movieId).FirstOrDefaultAsync();
            if (foundMovie != null)
            {
                foundMovie.Director = null;
                Save();
            }
        }

        public void Delete(object deleteObj)
        {
            _context.Remove(deleteObj);
            _context.SaveChanges();
        }
    }
}
