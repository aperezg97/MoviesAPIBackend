using MoviesAPI.Models.DTO;
using MoviesAPI.Models;
using MoviesAPI.Persistence.Interfaces;

namespace MoviesAPI.Persistence.Translators
{
    public class CategoryTranslator : ICategoryTranslator
    {
        public CategoryDTO ToCategoryDTO(Category category)
        {
            return new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}
