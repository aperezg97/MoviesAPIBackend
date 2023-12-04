using MoviesAPI.Models;
using MoviesAPI.Models.DTO;
using MoviesAPI.Models.RequestModels;

namespace MoviesAPI.Core.Interfaces
{
    public interface IGetMoviesQuery
    {
        Task<List<MovieDTO>> Run(GetMoviesRequestModel? requestParams = null);
    }
}
