using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MoviesAPI.Models;

namespace MoviesAPI.Persistence.Interfaces
{
    public interface IMoviesRepository
    {
        Task<List<Movie>> GetAll();
    }
}
