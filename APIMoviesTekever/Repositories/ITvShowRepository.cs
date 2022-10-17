using APIMoviesTekever.Models;

namespace APIMoviesTekever.Repositories
{
    public interface ITvShowRepository
    {
        Task<List<TvShowDTO>> GetTvShowsDTO();
        Task<List<TvShowDTO>> FilterTvShowDTO(HttpFilter filter);
        Task<List<EpisodeDTO>> GetEpisodesByTvShow(int id);
        Task<List<ActorDTO>> GetActorsByTvShow(int id);
        Task<int?> PostFavoriteTvShow(int id);
        Task<int?> RemoveFavoriteTvShow(int id);

    }
}
