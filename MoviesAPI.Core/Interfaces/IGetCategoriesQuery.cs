using MoviesAPI.Models.DTO;

namespace MoviesAPI.Core.Interfaces
{
    public interface IGetCategoriesQuery
    {
        Task<List<CategoryDTO>> Run();
    }
}
