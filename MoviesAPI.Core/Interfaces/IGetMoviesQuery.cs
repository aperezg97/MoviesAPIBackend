using MoviesAPI.Models;
using MoviesAPI.Models.DTO;

namespace MoviesAPI.Core.Interfaces
{
    public interface IGetMoviesQuery
    {
        Task<List<MovieDTO>> Run();
    }
}
