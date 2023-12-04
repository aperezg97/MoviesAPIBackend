using Microsoft.EntityFrameworkCore;

using MoviesAPI.Models;
using MoviesAPI.Persistence.DbContexts;
using MoviesAPI.Persistence.Interfaces;

namespace MoviesAPI.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MovieDbContext _dbContext;

        public CategoryRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _dbContext.Categories.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
