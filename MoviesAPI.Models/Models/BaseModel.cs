namespace MoviesAPI.Models.Models
{
    public abstract class BaseModel
    {
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
