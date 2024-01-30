namespace FilmLibrary.Lib.Models
{
    public class MovieModel
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Director { get; set; } = null!;
        public int IMDBRating { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
