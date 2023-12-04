namespace MoviesAPI.Models.DTO
{
    public class MovieDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public string? Description { get; set; }
        public string? Picture { get; set; }
        public List<CategoryDTO> Categories { get; set; } = new();
    }
}
