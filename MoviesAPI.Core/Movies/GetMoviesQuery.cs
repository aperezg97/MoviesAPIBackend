using MoviesAPI.Core.Interfaces;
using MoviesAPI.Models;
using MoviesAPI.Persistence.Interfaces;

namespace MoviesAPI.Core.Movies
{
    public class GetMoviesQuery : IGetMoviesQuery
    {
        private readonly IMoviesRepository _moviesRepository;

        public GetMoviesQuery(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        public async Task<List<Movie>> Run()
        {
            return await _moviesRepository.GetAll();
        }
    }
}
