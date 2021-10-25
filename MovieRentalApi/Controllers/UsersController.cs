using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieRentalApi.Filters;
using MovieRentalApi.Messages.Users;
using MRAPP.Extensions;
using MRAPP.Extensions.Messages;
using MRAPP.Messages.Users;
using MRAPP.Services.Movies;
using MRAPP.Services.Users;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieRentalApi.Controllers
{ 
	[Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
		private readonly IMovieService movieService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterUserAsync([FromBody] UserRegistrationWebRequest webRequest)
        {
            var result = await this.userService.RegisterUserAsync(webRequest.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }

		[ServiceFilter(typeof(DependencyFilter))]
		[TestActionAttribute]
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetUsersAsync([FromBody] GetUsersWebRequest webRequest)
        {
            var result = await this.userService.GetUsersAsync(webRequest.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }
    }
}
