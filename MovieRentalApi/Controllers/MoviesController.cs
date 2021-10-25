using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MRAPP.Extensions;
using MRAPP.Extensions.Messages;
using MRAPP.Messages.Movies;
using MRAPP.Services.Movies;
using System;
using System.Threading.Tasks;

namespace MovieRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService movieService;

        public MoviesController(IMovieService movieService)
        {
            this.movieService = movieService;
        }
      
        [HttpGet("{id:guid}")]
        [Authorize(Roles = "Customer, Admin")]
        public async Task<IActionResult> GetMovieByIdAsync(Guid id)
        {
            var webRequest = new GetMovieByIdWebRequest { Id = id };
            var result = await this.movieService.GetMovieByIdAsync(webRequest.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }

        [HttpGet]
        [Authorize(Roles = "Customer, Admin")]
        public async Task<IActionResult> GetMoviesAsync(GetMoviesWebRequest webRequest)
        {
            var result = await this.movieService.GetMoviesAsync(webRequest.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddMovieAsync([FromBody] AddMovieWebRequest webRequest)
        {
            var result = await this.movieService.AddMovieAsync(webRequest.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateMovieAsync([FromBody] UpdateMovieWebRequest webRequest)
        {
            var result = await this.movieService.UpdateMovieAsync(webRequest.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }

        [HttpDelete("{id:guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteMovieAsync(Guid id)
        {
            var webRequest = new DeleteMovieWebRequest { Id = id };
            var result = await this.movieService.DeleteMovieAsync(webRequest.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }
    }
}
