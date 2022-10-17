using APIMoviesTekever.Entities;
using APIMoviesTekever.Models;
using APIMoviesTekever.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIMoviesTekever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvShowController : ControllerBase
    {

        private ITvShowRepository _tvShow;

        public TvShowController(ITvShowRepository repository)
        {
            this._tvShow = repository;
        }

        [HttpGet("ListTvShows")]
        public async Task<ActionResult<List<TvShowDTO>>> GetTvShows()
        {
            try
            {
                var List = await _tvShow.GetTvShowsDTO();

                foreach(TvShowDTO tvshow in List)
                {
                    var actors = await _tvShow.GetActorsByTvShow(tvshow.Id);
                    tvshow.LsActors = actors;
                }

                foreach (TvShowDTO tvshow in List)
                {
                    var episodes = await _tvShow.GetEpisodesByTvShow(tvshow.Id);
                    tvshow.LsEpisodes = episodes;
                }

                if (List.Count <= 0)
                {
                    return NotFound(new HttpRes { StatusCode = 404, Message = "Tv Show Not Found" });
                }
                return Ok(List);
            }
            catch(Exception e)
            {
                return Problem(e.Message);
            }
            
        }

        [HttpPost("ListByFilter")]
        public async Task<ActionResult<List<TvShowDTO>>> GetFilterTvShows([FromBody] HttpFilter filter)
        {
            try
            {
                var List = await _tvShow.FilterTvShowDTO(filter);

                foreach (TvShowDTO tvshow in List)
                {
                    var actors = await _tvShow.GetActorsByTvShow(tvshow.Id);
                    tvshow.LsActors = actors;
                }

                foreach (TvShowDTO tvshow in List)
                {
                    var episodes = await _tvShow.GetEpisodesByTvShow(tvshow.Id);
                    tvshow.LsEpisodes = episodes;
                }

                if (List.Count <= 0)
                {
                    return NotFound(new HttpRes { StatusCode = 404, Message = "Tv Show Not Found" });
                }
                return Ok(List);
            }
            catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpGet("FavoriteTvShow/{TvShowId}")]
        public async Task<ActionResult> FavoriteTvShow(int TvShowId)
        {
            try
            {
                var status = await _tvShow.PostFavoriteTvShow(TvShowId);
                return Ok("Favoritado com sucesso");
            }
            catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpGet("RemoveFavoriteTvShow/{TvShowId}")]
        public async Task<ActionResult> RemoveFavoriteTvShow(int TvShowId)
        {
            try
            {
                var status = await _tvShow.PostFavoriteTvShow(TvShowId);
                return Ok("Desfavoritado com sucesso");
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }


    }
}
