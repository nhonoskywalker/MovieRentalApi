using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MRAPP.Extensions;
using MRAPP.Extensions.Messages;
using MRAPP.Messages.Authentication;
using MRAPP.Services.Authentication;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationService authenticationService;

        public LoginController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LogInWebRequest webRequest)
        {
            var result = await this.authenticationService.AuthenticateUserAsync(webRequest.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }
    }
}
