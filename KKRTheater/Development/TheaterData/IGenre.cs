
using System.Collections.Generic;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace TheaterData
{
    public interface IGenre
    {
        Task<ICollection<Genre>> GetAll();
        Task<ICollection<Genre>> GetAllLight();
        Task<Genre> GetById(int id);

        void Add(Genre newGenre);

        Task<ICollection<Movie>> GetMovies(int id);

    }
}
