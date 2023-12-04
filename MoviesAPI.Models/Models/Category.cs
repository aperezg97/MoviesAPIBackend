using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
    }
}
