using MoviesAPI.Core.Interfaces;
using MoviesAPI.Models.DTO;
using MoviesAPI.Persistence.Interfaces;

namespace MoviesAPI.Core.Movies
{
    public class GetCategoriesQuery : IGetCategoriesQuery
    {
        private readonly ICategoryRepository _repository;
        private readonly ICategoryTranslator _translator;

        public GetCategoriesQuery(ICategoryRepository categoryRepository, ICategoryTranslator categoryTranslator)
        {
            _repository = categoryRepository;
            _translator = categoryTranslator;
        }

        public async Task<List<CategoryDTO>> Run()
        {
            var result = await _repository.GetAll();
            return result.Select(_translator.ToCategoryDTO).ToList();
        }
    }
}
