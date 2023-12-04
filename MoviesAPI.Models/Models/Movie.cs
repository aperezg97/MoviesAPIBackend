using System.ComponentModel.DataAnnotations;

using MoviesAPI.Models.Models;

namespace MoviesAPI.Models
{
    public class Movie : BaseModel
    {
        public Guid Id { get; set; }
        [StringLength(1000)]
        public string? Name { get; set; }
        [StringLength(1000)]
        public string? Title { get; set; }
        public int Year { get; set; }
        [StringLength(5000)]
        public string? Description { get; set; }
        [StringLength(1000)]
        public string? Picture { get; set; }
        public List<Category> Categories { get; set; } = new();
    }
}
