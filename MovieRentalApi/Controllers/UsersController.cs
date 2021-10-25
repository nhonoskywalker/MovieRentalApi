using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetUsersAsync()
        {
            var webRequest = new GetUsersWebRequest();
            var result = await this.userService.GetUsersAsync(webRequest.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }
    }
}
