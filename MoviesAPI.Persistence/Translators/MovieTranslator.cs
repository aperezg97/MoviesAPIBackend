using MoviesAPI.Models.DTO;
using MoviesAPI.Persistence.Interfaces;

namespace MoviesAPI.Models.Translators
{
    public class MovieTranslator : IMovieTranslator
    {
        private readonly ICategoryTranslator _categoryTranslator;

        public MovieTranslator(ICategoryTranslator categoryTranslator)
        {
            _categoryTranslator = categoryTranslator;
        }

        // TODO: USE MAPPER, MAYBE (?)
        public MovieDTO ToMovieDTO(Movie movie)
        {
            return new MovieDTO()
            {
                Id = movie.Id,
                Name = movie.Name,
                Title = movie.Title,
                Picture = movie.Picture,
                Year = movie.Year,
                Description = movie.Description,
                Categories = movie.Categories?.Select(_categoryTranslator.ToCategoryDTO).ToList(),
            };
        }
    }
}
