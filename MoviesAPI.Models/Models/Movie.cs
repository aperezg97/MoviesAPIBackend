namespace MoviesAPI.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
    }
}
