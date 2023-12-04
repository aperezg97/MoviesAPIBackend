using MoviesAPI.Models;

namespace MoviesAPI.Core.Interfaces
{
    public interface IGetMoviesQuery
    {
        Task<List<Movie>> Run();
    }
}
