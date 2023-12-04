using Microsoft.Extensions.DependencyInjection;

using MoviesAPI.Models.Translators;
using MoviesAPI.Persistence.Interfaces;
using MoviesAPI.Persistence.Repositories;
using MoviesAPI.Persistence.Translators;

namespace MoviesAPI.Persistence.DI
{
    public static class PersistenceDI
    {
        public static void AddPersistenceServices(this IServiceCollection service)
        {
            service.AddScoped<IMoviesRepository, MoviesRepository>();
            service.AddScoped<ICategoryRepository, CategoryRepository>();
            service.AddSingleton<IMovieTranslator, MovieTranslator>();
            service.AddSingleton<ICategoryTranslator, CategoryTranslator>();
        }
    }
}
