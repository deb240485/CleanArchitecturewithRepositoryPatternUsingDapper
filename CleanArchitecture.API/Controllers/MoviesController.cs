using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var movies = await _movieService.GetAllMovies();

            return Ok(movies);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Movie movie)
        {
            await _movieService.CreateMovie(movie);
            return Ok(movie);
        }
    }
}
