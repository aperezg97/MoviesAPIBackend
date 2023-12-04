using MoviesAPI.Models;

namespace MoviesAPI.Persistence.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
    }
}
