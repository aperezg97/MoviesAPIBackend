using MoviesAPI.Core.Interfaces;
using MoviesAPI.Models.DTO;
using MoviesAPI.Models.RequestModels;
using MoviesAPI.Persistence.Interfaces;

namespace MoviesAPI.Core.Movies
{
    public class GetMoviesQuery : IGetMoviesQuery
    {
        private readonly IMoviesRepository _moviesRepository;
        private readonly IMovieTranslator _movieTranslator;

        public GetMoviesQuery(IMoviesRepository moviesRepository, IMovieTranslator movieTranslator)
        {
            _moviesRepository = moviesRepository;
            _movieTranslator = movieTranslator;

        }

        public async Task<List<MovieDTO>> Run(GetMoviesRequestModel? requestParams = null)
        {
            var result = await _moviesRepository.GetAll(requestParams);
            return result.Select(_movieTranslator.ToMovieDTO).ToList();
        }
    }
}
