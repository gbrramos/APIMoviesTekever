using System.ComponentModel.DataAnnotations;

namespace APIMoviesTekever.Models
{
    public class TvShowDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int Genre { get; set; }
        public string Type { get; set; } = null!; //S = Série, M = Movie
        public List<ActorDTO> LsActors { get; set; }
        public List<EpisodeDTO>? LsEpisodes { get; set; }
        public int? Favorite { get; set; } //1 = True, 0 = False
    }
}
