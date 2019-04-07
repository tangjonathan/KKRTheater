
using System.Collections.Generic;
using System.Threading.Tasks;
using TheaterData.Entities;

namespace TheaterData
{
    public interface IMovie
    {
        Task<ICollection<Movie>> GetAllLight();
        Task<ICollection<Movie>> GetAll();
        Task<Movie> GetById(int id);
        Task<Movie> GetByTitle(string title);
        void Add(Movie newMovie);
        void Save();
        void AddGenre(Movie movie, int genreId);
        void RemoveGenre(Movie movie, int genreId);
        void AddActor(Movie movie, int actorId);
        void RemoveActor(Movie movie, int actorId);
        void AddDirector(Movie movie, Director director);
        Task<ICollection<Genre>> GetGenres(int id);
        Task<ICollection<Actor>> GetActors(int id);

        void Delete(object deleteObj);

    }
}
