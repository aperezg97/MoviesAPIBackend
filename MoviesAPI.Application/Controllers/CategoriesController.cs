using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using MoviesAPI.Core.Interfaces;

using MoviesAPI.Models.DTO;

namespace MoviesAPI.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {

        private readonly ILogger<CategoriesController> _logger;
        private readonly IGetCategoriesQuery _getCategoriesQuery;

        public CategoriesController(ILogger<CategoriesController> logger, IGetCategoriesQuery getCategoriesQuery)
        {
            _logger = logger;
            _getCategoriesQuery = getCategoriesQuery;

        }

        [HttpGet]
        public async Task<IEnumerable<CategoryDTO>> Get()
        {
            return await _getCategoriesQuery.Run();
        }
    }
}
