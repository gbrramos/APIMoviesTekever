using APIMoviesTekever.Entities;
using APIMoviesTekever.Models;
using Microsoft.EntityFrameworkCore;

namespace APIMoviesTekever.Repositories
{
    public class TvShowRepository: ITvShowRepository
    {
        private readonly teverkContext context;

        public TvShowRepository(teverkContext context)
        {
            this.context = context;
        }

        public async Task<List<TvShowDTO>> GetTvShowsDTO()
        {
            return await context.TvShows.Select(s => new TvShowDTO
            {
                Id = s.Id,
                Name = s.Name,
                Author = s.Author,
                Genre = s.Genre,
                Type = s.Type,
                Favorite = s.Favorite
            })
            .ToListAsync();
        }

        public async Task<List<TvShowDTO>> FilterTvShowDTO(HttpFilter filter)
        {
            var genre = await context.Genres.Select(s => new GenreDTO
            {
                Id = s.Id,
                Name = s.Name
            })
            .FirstOrDefaultAsync(s => s.Name.ToLower() == filter.Genre.ToLower());

            var List = await context.TvShows.Select(s => new TvShowDTO
            {
                Id = s.Id,
                Name = s.Name,
                Author = s.Author,
                Genre = s.Genre,
                Type = s.Type,
                Favorite = s.Favorite
            })
            .ToListAsync();

            return List.Where(a => a.Genre == genre.Id && a.Type.ToLower() == filter.Type.ToLower()).ToList();
        }
        public async Task<List<EpisodeDTO>> GetEpisodesByTvShow(int id)
        {
            var List = await context.Episodes.Select(s => new EpisodeDTO
            {
                Id = s.Id,
                Name = s.Name,
                Temp = s.Temp,
                Duration = s.Duration,
                ReleaseDate = DateTime.Parse(s.ReleaseDate),
                TvshowId = s.TvshowId,
            })
            .ToListAsync();

            return List.Where(a => a.TvshowId == id).ToList();
        }

        public async Task<List<ActorDTO>> GetActorsByTvShow(int id)
        {
            List<ActorDTO> res = new List<ActorDTO>();

            var ListAllActors = await context.ActorTvshows.Select(s => new ActorTvshow 
            { 
                ActorId = s.ActorId,
                TvshowId = s.TvshowId,
            }).ToListAsync();

            var ListIdActors = ListAllActors.Where(a => a.TvshowId == id).ToList();

            foreach(ActorTvshow actorShow in ListIdActors)
            {
                var actor = await context.Actors.Select(s => new ActorDTO
                {
                    Age = s.Age,
                    Id = s.Id,
                    Name = s.Name
                }).FirstOrDefaultAsync(s => s.Id == actorShow.ActorId);
                res.Add(actor);
            }

            return res;
        }

        public async Task<int?> PostFavoriteTvShow(int id)
        {
            var entity = await context.TvShows.FirstOrDefaultAsync(s => s.Id == id);
            entity.Favorite = 1;
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int?> RemoveFavoriteTvShow(int id)
        {
            var entity = await context.TvShows.FirstOrDefaultAsync(s => s.Id == id);
            entity.Favorite = 0;
            await context.SaveChangesAsync();
            return 1;
        }
    }
}
