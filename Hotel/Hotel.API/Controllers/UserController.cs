using Hotel.Business.DTOs;
using Hotel.Business.Services.Users;
using Hotel.Common;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("GetUsers")]
        public async Task<Response<PagingDto<UserDto>>> GetUsers(int pageSize, int pageNumber)
        {
            return await userService.GetUsers(pageSize, pageNumber).ConfigureAwait(false);
        }
    }
}
