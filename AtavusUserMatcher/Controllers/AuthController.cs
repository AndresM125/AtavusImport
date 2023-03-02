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
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using AtavusUserMatcher.RouteModels;
using AtavusUserMatcher.Models;

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

        private readonly atavusContext db;

        public AuthController(ILogger<AuthController> logger, IConfiguration configuration, atavusContext db)
        {
            _logger = logger;
            Username = configuration.GetSection("AdminUsername").Value;
            Password = configuration.GetSection("AdminPassword").Value;
            JWT_KEY = configuration.GetSection("JWT_KEY").Value;
            JWT_AUTH_AUD = configuration.GetSection("JWT_AUTH_AUD").Value;
            this.db = db;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginParam data)
        {
            if (data.Username == Username && data.Password == Password)
            {
                return Ok(new LoginResult()
                {
                    Token = GenerateJwtToken(Username)
                });
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("sendCustomer2Fac")]
        public async Task<IActionResult> SendCustomer2Fac([FromBody] SendCustomer2FacParam data)
        {
            var accountSid = "AC434aec2502dceb4a4bf72083612eb6cf";
            var authToken = "bd70d31587bd3f3e964dc254dd188792";
            TwilioClient.Init(accountSid, authToken);

            string otp = (BetterRandom.NextInt() % 1000000).ToString("000000");

            var user = await db.Users.FirstOrDefaultAsync(x => x.Id == data.CustomerId);
            if (user == null)
            {
                return NotFound();
            }
            user.TwoFactorAuthCode = otp;
            await db.SaveChangesAsync();

            var messageOptions = new CreateMessageOptions(new PhoneNumber(data.PhoneNumber))
            {
                MessagingServiceSid = "MG04901171d869994e5a5c26f8269418c9",
                Body = $"Your 6 digit Atavus verification code is {otp}"
            };
            var message = MessageResource.Create(messageOptions);

            return Ok();
        }

        [HttpPost]
        [Route("verifyCustomer2Fac")]
        public async Task<IActionResult> VerifyCustomer2Fac([FromBody] VerifyCustomer2FacParam data)
        {
            var user = await db.Users.FirstOrDefaultAsync(x => x.Id == data.CustomerId);
            if (user == null)
            {
                return NotFound();
            }
            if (!String.Equals(user.TwoFactorAuthCode, data.Code, StringComparison.InvariantCultureIgnoreCase))
            {
                return BadRequest();
            }

            user.TwoFactorAuthCode = null;
            user.IsEmailVerified = true;
            await db.SaveChangesAsync();

            return Ok();
        }

        public static class BetterRandom
        {
            private static readonly ThreadLocal<System.Security.Cryptography.RandomNumberGenerator> crng = new ThreadLocal<System.Security.Cryptography.RandomNumberGenerator>(System.Security.Cryptography.RandomNumberGenerator.Create);
            private static readonly ThreadLocal<byte[]> bytes = new ThreadLocal<byte[]>(() => new byte[sizeof(int)]);
            public static int NextInt()
            {
                crng.Value.GetBytes(bytes.Value);
                return BitConverter.ToInt32(bytes.Value, 0) & int.MaxValue;
            }
            public static double NextDouble()
            {
                while (true)
                {
                    long x = NextInt() & 0x001FFFFF;
                    x <<= 31;
                    x |= (long)NextInt();
                    double n = x;
                    const double d = 1L << 52;
                    double q = n / d;
                    if (q != 1.0)
                        return q;
                }
            }
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