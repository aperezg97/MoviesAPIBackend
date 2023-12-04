using Microsoft.Extensions.DependencyInjection;

using MoviesAPI.Core.Interfaces;
using MoviesAPI.Core.Movies;


namespace MoviesAPI.Core.DI
{
    public static class CoreDI
    {
        public static void AddCoreServices(this IServiceCollection service)
        {
            service.AddScoped<IGetMoviesQuery, GetMoviesQuery>();
        }
    }
}
