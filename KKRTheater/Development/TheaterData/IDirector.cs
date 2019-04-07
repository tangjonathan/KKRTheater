
using System.Collections.Generic;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace TheaterData
{
    public interface IDirector
    {
        Task<ICollection<Director>> GetAll();
        Task<Director> GetById(int id);
        Task<Director> GetByName(string name);

        Task AddMovie(Director director, int movieId);
        Task RemoveMovie(Director director, int movieId);
        void Add(Director newDirector);
        void Save();
        void Delete(object director);
        Task<ICollection<Movie>> GetMovies(int id);

    }
}
