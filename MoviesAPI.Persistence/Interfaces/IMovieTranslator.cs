using MoviesAPI.Models;
using MoviesAPI.Models.DTO;

namespace MoviesAPI.Persistence.Interfaces
{
    public interface IMovieTranslator
    {
        MovieDTO ToMovieDTO(Movie movie);
    }
}
