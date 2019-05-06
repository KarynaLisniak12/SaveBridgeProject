using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SaveBridge.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using SaveBridge.BusinessLogic.Services.Interfaces;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        /// <summary>
        /// Sign In by credentials
        /// </summary>
        /// <param name="model"></param>
        /// <returns>JWT token</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPost("signIn")]
        public async Task<IActionResult> SignIn([FromBody]SignInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isRegistered = await _service.IsRegistered(model);
            if (isRegistered)
            {
                string token = GenerateJwtToken();
                return Ok(new
                {
                    token
                });
            }

            return Unauthorized();
        }

        /// <summary>
        /// Sign Up by credentials
        /// </summary>
        /// <param name="model"></param>
        /// <returns>JWT token</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("signUp")]
        public async Task<IActionResult> SignUp([FromBody]SignUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isSignUp = await _service.SignUp(model);
            if (isSignUp)
            {
                string token = GenerateJwtToken();
                return Ok(new
                {
                    token
                });
            }

            return BadRequest();
        }

        private string GenerateJwtToken()
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokeOptions = new JwtSecurityToken(
                "https://localhost:44337",
                "https://localhost:44337",
                new List<Claim>(),
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: signingCredentials
            );

            string jwtToken = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return jwtToken;
        }
    }
}