using AutoMapper;
using GlobalHelpers.Helpers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.ViewModels;
using Services.Interfaces;
using SharedConfig.Messages;
using System;
using System.Threading.Tasks;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public UsersController(IMapper Mapper, IUserService UserService)
        {
            this._mapper = Mapper;
            this._userService = UserService;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateUser([FromBody] VmUserCreate vmUserCreate)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    User createdUser = await _userService.CreateUser(vmUserCreate);
                    VmUser vmUser = _mapper.Map<VmUser>(createdUser);
                    return Ok(DataMessage.Data(vmUser));
                }
                catch (AppException ex)
                {
                    return BadRequest(ex.ReturnBadRequest());
                }
                catch (Exception ex)
                {
                    return BadRequest(AppException.ReturnBadRequest(ex.Message));
                }
            }
            else
            {
                return BadRequest(AppException.ReturnBadRequest(ModelState));
            }
        }
    }
}
