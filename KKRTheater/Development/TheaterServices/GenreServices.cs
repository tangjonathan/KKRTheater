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
    public class GenreServices : IGenre
    {
        private TheaterContext _context;
        public GenreServices(TheaterContext context)
        {
            _context = context;
        }

        public void Add(Genre newGenre)
        {
            _context.Add(newGenre);
            _context.SaveChanges();
        }

        public async Task<ICollection<Genre>> GetAllLight()
        {
            return await _context.Genres
                .OrderBy(genre => genre.Name).ToListAsync();
        }

        public async Task<ICollection<Genre>> GetAll()
        {
            return await _context.Genres
                .Include(genre => genre.MovieGenres)
                    .ThenInclude(movieGenre => movieGenre.Movie)
                .OrderBy(genre => genre.Name).ToListAsync();
        }

        public async Task<Genre> GetById(int id)
        {
            return await _context.Genres
                .Include(genre => genre.MovieGenres)
                    .ThenInclude(movieGenre => movieGenre.Movie)
                .FirstOrDefaultAsync(genre => genre.Id == id);
        }

        public async Task<ICollection<Movie>> GetMovies(int id)
        {
            Genre genre = await GetById(id);

            if (genre != null)
            {
                return await genre
                    .MovieGenres.Select(movieGenre => movieGenre.Movie).ToAsyncEnumerable()
                    .ToList();
            }
            else
                return null;
        }
    }
}
