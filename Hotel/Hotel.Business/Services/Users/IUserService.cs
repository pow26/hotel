using Hotel.Business.DTOs;
using Hotel.Common;

namespace Hotel.Business.Services.Users
{
    public interface IUserService
    {
        Task<Response<PagingDto<UserDto>>> GetUsers(int pageSize, int pageNumber);
    }
}
