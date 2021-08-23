using GlobalHelpers.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Models;
using Services.Interfaces;
using SharedConfig.Config;
using SharedConfig.Messages;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using APIs.Utilities;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : AppController
    {
        private readonly AppConfig _config;
        private readonly IUserService _userService;
        public AuthenticateController(AppConfig config, IUserService userService)
        {
            _config = config;
            _userService = userService;
        }

        [Route("login")]
        [HttpPost]
        public async Task<GResponse<VmLoginResponse>> Login([FromBody] VmLoginRequest LoginRequest)
        {
            return await ExceptionHandler(async () =>
            {
                User user = await _userService.ValidateUserToLogin(LoginRequest.UserName, LoginRequest.Password);
                string JWTToken = _userService.GenerateUserToken(user);
                return Ok(new VmLoginResponse() { Token = JWTToken });
            });
        }
    }
}
