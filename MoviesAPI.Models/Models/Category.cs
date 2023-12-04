using System.ComponentModel.DataAnnotations;

using MoviesAPI.Models.Models;

namespace MoviesAPI.Models
{
    public class Category : BaseModel
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
        public List<Movie> Movies { get; set; } = new();
    }
}
