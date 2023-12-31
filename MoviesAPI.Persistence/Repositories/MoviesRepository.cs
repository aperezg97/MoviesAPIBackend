﻿using System.Linq;
using System.Security.Cryptography;

using Microsoft.EntityFrameworkCore;

using MoviesAPI.Models;
using MoviesAPI.Models.RequestModels;
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

        public async Task<List<Movie>> GetAll(GetMoviesRequestModel? requestParams = null)
        {
            if (requestParams == null) requestParams = new GetMoviesRequestModel();

            var searchParam = requestParams.FreeTextSearch;
            if (!string.IsNullOrEmpty(searchParam))
            {
                searchParam = "%" + searchParam + "%";
            }

            return await
            (
            from m in _dbContext.Movies
            where
                (string.IsNullOrEmpty(searchParam) ||
                    (EF.Functions.Like(m.Title, searchParam)) ||
                    (EF.Functions.Like(m.Name, searchParam)) ||
                    (EF.Functions.Like(m.Description, searchParam))
                )
                &&
                (
                    (requestParams.Categories == null || requestParams.Categories.Count == 0) ||
                    m.MovieCategories.Any(mCatg => requestParams.Categories.Contains(mCatg.CategoryId))
                )
            select m
            ).Include(x => x.Categories)
             .OrderByDescending(x => x.Year)
                .ThenBy(x => x.Title)
                .ToListAsync();
        }
    }
}
