namespace MoviesAPI.Models.RequestModels
{
    public class GetMoviesRequestModel
    {
        public List<Guid>? Categories { get; set; }
        public string? FreeTextSearch { get; set; }
    }
}
