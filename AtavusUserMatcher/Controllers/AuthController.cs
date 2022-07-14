using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace AtavusUserMatcher.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        private readonly string Username;
        private readonly string Password;
        private readonly string JWT_KEY;
        private readonly string JWT_AUTH_AUD;

        public AuthController(ILogger<AuthController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Username = configuration.GetSection("Username").Value;
            Password = configuration.GetSection("Password").Value;
            JWT_KEY = configuration.GetSection("JWT_KEY").Value;
            JWT_AUTH_AUD = configuration.GetSection("JWT_AUTH_AUD").Value;

            Console.WriteLine(JWT_KEY);
            Console.WriteLine(JWT_AUTH_AUD);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Login([FromBody] LoginParam data)
        {
            Console.WriteLine(data.Username);
            Console.WriteLine(data.Password);
            Console.WriteLine(Username);
            Console.WriteLine(Password);

            if (data.Username == Username && data.Password == Password)
            {
                return Ok(new LoginResult()
                {
                    Token = GenerateJwtToken(Username)
                });
            }

            return BadRequest();
        }

        public class LoginParam
        {  
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class LoginResult
        {
            public string Token { get; set; }
        }
        
        private string GenerateJwtToken(string username)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, username)
            };

            var creds = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWT_KEY)), SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(JWT_AUTH_AUD, JWT_AUTH_AUD, claims, signingCredentials: creds, expires: DateTime.UtcNow.AddYears(1));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}