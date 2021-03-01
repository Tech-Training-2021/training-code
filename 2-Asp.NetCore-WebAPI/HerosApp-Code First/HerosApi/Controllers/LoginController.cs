using HerosApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HerosApi.Controllers
{
    /// <summary>
    /// Login controller
    /// </summary>
    [Route("api/auth")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public LoginController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpPost,Route("login")]
        public IActionResult Login([FromBody] Login user)
        {
            if (user == null)
            {
                return BadRequest("Invalid Client Request, user cannot be empty");
            }
            if (user.userName == "John" && user.password == "Password123")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));//(Configuration["IssuerSigningKey"]));
                var signInCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: "https://superherowebapi.azurewebsites.net/",//Configuration["ValidIssuer"],
                    audience: "https://superherowebapi.azurewebsites.net/", //Configuration["ValidAudience"],
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signInCredentials
                    );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { Token = tokenString });
            }
            else
                return Unauthorized();
        }
    }
}
