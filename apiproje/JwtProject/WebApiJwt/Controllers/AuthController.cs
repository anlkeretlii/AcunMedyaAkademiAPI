using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult CreateToken([FromBody] LoginRequest request)
        {
            // Basit kullanıcı doğrulama (gerçek uygulamada veritabanından kontrol edilir)
            if (request.Username == "admin" && request.Password == "123456")
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes("jsonwebtokensuperapijsonwebtokensuperapi");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, request.Username),
                        new Claim(ClaimTypes.Role, "Admin"),
                        new Claim("UserId", "1")
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    Issuer = "http://localhost",
                    Audience = "http://localhost",
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);

                return Ok(new
                {
                    Token = tokenString,
                    ExpiresAt = tokenDescriptor.Expires
                });
            }

            return Unauthorized("Geçersiz kullanıcı adı veya şifre");
        }

        [HttpGet("test")]
        [Microsoft.AspNetCore.Authorization.Authorize]
        public IActionResult TestAuth()
        {
            var username = User.Identity?.Name;
            var userId = User.FindFirst("UserId")?.Value;
            var role = User.FindFirst(ClaimTypes.Role)?.Value;

            return Ok(new
            {
                Message = "Bu korumalı bir endpoint",
                Username = username,
                UserId = userId,
                Role = role
            });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
} 