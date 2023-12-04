using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using MoviesAPI.Core.Interfaces;
using MoviesAPI.Models;

namespace MoviesAPI.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<MovieController> _logger;
        private readonly IGetMoviesQuery _getMoviesQuery;

        public MovieController(ILogger<MovieController> logger, IGetMoviesQuery getMoviesQuery)
        {
            _logger = logger;
            _getMoviesQuery = getMoviesQuery;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> Get()
        {
            return await _getMoviesQuery.Run();

            //return Enumerable.Range(1, 5).Select(index => new Movie
            //{
            //    Year = Random.Shared.Next(-20, 55),
            //    Name = Summaries[Random.Shared.Next(Summaries.Length)],
            //    Title = Summaries[Random.Shared.Next(Summaries.Length)],

            //})
            //.ToArray();
        }
    }
}
