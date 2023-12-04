using MoviesAPI.Models;
using MoviesAPI.Models.RequestModels;

namespace MoviesAPI.Persistence.Interfaces
{
    public interface IMoviesRepository
    {
        Task<List<Movie>> GetAll(GetMoviesRequestModel? requestParams = null);
    }
}
