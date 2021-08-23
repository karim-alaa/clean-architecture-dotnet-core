using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Models;
using Services.Interfaces;
using AutoMapper;
using GlobalHelpers.Helpers;
using SharedConfig.Messages;
using Models.ViewModels;
using APIs.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : AppController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public UsersController(IMapper Mapper,IUserService UserService)
        {
            _mapper = Mapper;
            _userService = UserService;
        }

        [HttpPost]
        [Route("Create")]
        [Authorize]
        public async Task<GResponse<VmUser>> CreateUser([FromBody] VmUserCreate vmUserCreate)
        {
            return await ExceptionHandler(async () =>
            {
                User createdUser = await _userService.CreateUser(vmUserCreate);
                VmUser vmUser = _mapper.Map<VmUser>(createdUser);
                return Ok(vmUser);
            });
        }
    }
}
