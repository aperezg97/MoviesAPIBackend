using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MoviesAPI.Models.DTO;
using MoviesAPI.Models;

namespace MoviesAPI.Persistence.Interfaces
{
    public interface ICategoryTranslator
    {
        CategoryDTO ToCategoryDTO(Category category);
    }
}
