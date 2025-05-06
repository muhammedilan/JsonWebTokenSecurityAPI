using JsonWebTokenSecurityAPI.Entities;
using JsonWebTokenSecurityAPI.Models;
using Microsoft.AspNetCore.Mvc;
using JsonWebTokenSecurityAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace JsonWebTokenSecurityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            var user = await authService.RegisterAsync(request);

            if (user is null)
                return BadRequest("Username already exists");

            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            var result = await authService.LoginAsync(request);

            if (result is null)
                return BadRequest("Invalid username or password");

            return Ok(result);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AuthenticatedOnlyEndpoint()
        {
            return Ok("You are authenticated!");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin-only")]
        public IActionResult AdminOnlyEndpoint()
        {
            return Ok("You are authenticated and admin!");
        }
    }
}
