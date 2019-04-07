
using System.Collections.Generic;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace TheaterData
{
    public interface IActor
    {
        Task<List<Actor>> GetAll();
        Task<List<Actor>> GetAllLight();
        Task<Actor> GetById(int id);
        Task<Actor> GetByName(string name);

        void Save();
        void Add(Actor newActor);
        void AddMovie(Actor actor, int movieId);
        void RemoveMovie(Actor actor, int movieId);
        void Delete(object deleteActor);

        Task<List<Movie>> GetMovies(int id);
        
        
    }
}
