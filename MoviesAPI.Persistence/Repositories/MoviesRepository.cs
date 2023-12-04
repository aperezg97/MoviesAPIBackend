﻿using Microsoft.EntityFrameworkCore;

using MoviesAPI.Models;
using MoviesAPI.Persistence.DbContexts;
using MoviesAPI.Persistence.Interfaces;

namespace MoviesAPI.Persistence.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly MovieDbContext _dbContext;

        public MoviesRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Movie>> GetAll()
        {
            return await _dbContext.Movies.Include(x => x.Categories).OrderByDescending(x => x.Year).ThenBy(x => x.Title).ToListAsync();
        }
    }
}
