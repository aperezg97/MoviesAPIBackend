using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        [StringLength(1000)]
        public string? Name { get; set; }
        [StringLength(1000)]
        public string? Title { get; set; }
        public int Year { get; set; }
        [StringLength(5000)]
        public string? Description { get; set; }
    }
}
