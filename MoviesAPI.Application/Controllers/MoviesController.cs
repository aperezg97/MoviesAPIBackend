using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using MoviesAPI.Core.Interfaces;
using MoviesAPI.Models.DTO;
using MoviesAPI.Models.RequestModels;

namespace MoviesAPI.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {

        private readonly ILogger<MoviesController> _logger;
        private readonly IGetMoviesQuery _getMoviesQuery;

        public MoviesController(ILogger<MoviesController> logger, IGetMoviesQuery getMoviesQuery)
        {
            _logger = logger;
            _getMoviesQuery = getMoviesQuery;
        }

        [HttpPost]
        public async Task<IEnumerable<MovieDTO>> Post([FromBody] GetMoviesRequestModel? requestParams = null)
        {
            return await _getMoviesQuery.Run(requestParams);
        }
    }
}
