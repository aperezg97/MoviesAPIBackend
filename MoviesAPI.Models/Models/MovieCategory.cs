using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models.Models
{
    public class MovieCategory : BaseModel
    {
        public int Id { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; } = null!;

        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
