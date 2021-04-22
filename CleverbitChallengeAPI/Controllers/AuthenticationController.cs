using Core.Models.DTOs;
using Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CleverbitChallengeAPI.Controllers
{
    [Route("[controller]/{action}")]
    public class AuthenticationController : ControllerBase
    {

        private AuthenticationHandler _authenticationHandler;

        public AuthenticationController(AuthenticationHandler authenticationHandler)
        {
            _authenticationHandler = authenticationHandler;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginDTO login)
        {
            var result = _authenticationHandler.Login(login);

            return new JsonResult(result);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register([FromBody] UserDTO user)
        {
            var result = _authenticationHandler.Register(user);

            return new JsonResult(result);
        }
    }
}
