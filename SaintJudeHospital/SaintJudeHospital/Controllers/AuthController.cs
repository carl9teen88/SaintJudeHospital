using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SaintJudeHospital.Data.Indentity;
using SaintJudeHospital.Model;

namespace SaintJudeHospital.Controllers
{        
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SaintJudeSecurityKey"));

                var token = new JwtSecurityToken(
                    issuer: "https://localhost:44363",
                    audience: "https://localhost:44363",
                    expires: DateTime.UtcNow.AddHours(12),
                    claims: claims,
                    signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
                    );

                var encoded_token = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(new
                {
                    Token = encoded_token,
                    Expiration = token.ValidTo
                });
            }

            return Unauthorized();
        }
    }
}