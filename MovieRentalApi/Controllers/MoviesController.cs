using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MRAPP.Extensions;
using MRAPP.Extensions.Messages;
using MRAPP.Messages.Movies;
using MRAPP.Services.Movies;
using System.Threading.Tasks;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

      
        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Customer, Admin")]
        public async Task<IActionResult> GetMovieByIdAsync(GetMovieByIdWebRequest request)
        {
            var result = await this.movieService.GetMovieById(request.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }

        // GET: api/<MoviesController>
        [HttpGet]
        [Authorize(Roles = "Customer, Admin")]
        public async Task<IActionResult> GetMoviesAsync(GetMoviesWebRequest request)
        {
            var result = await this.movieService.GetMovies(request.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }

        // POST api/<MoviesController>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public void Delete(int id)
        {
        }
    }
}
