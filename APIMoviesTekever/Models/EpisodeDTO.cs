namespace APIMoviesTekever.Models
{
    public class EpisodeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Temp { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TvshowId { get; set; }
    }
}
