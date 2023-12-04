using Microsoft.Extensions.DependencyInjection;

using MoviesAPI.Persistence.Interfaces;
using MoviesAPI.Persistence.Repositories;

namespace MoviesAPI.Persistence.DI
{
    public static class PersistenceDI
    {
        public static void AddPersistenceServices(this IServiceCollection service)
        {
            service.AddScoped<IMoviesRepository, MoviesRepository>();
        }
    }
}
