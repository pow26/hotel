using Hotel.Business.DTOs;
using Hotel.Common;
using Hotel.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Hotel.Business.Services.Users
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> logger;
        private IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork unitOfWork, ILogger<UserService> logger)
        {
            this.unitOfWork = unitOfWork;
            this.logger = logger;
        }

        public async Task<Response<PagingDto<UserDto>>> GetUsers(int pageSize, int pageNumber)
        {
            var response = new Response<PagingDto<UserDto>>();
            try
            {
                var query = from u in unitOfWork.Context.Users select new UserDto()
                {
                    Id = u.UserId,
                    Name = u.UserName,
                    Password = u.Password
                };
                var total = await query.CountAsync();
                var result = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                response.Data = new PagingDto<UserDto>(result, pageNumber, pageSize, total);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }

            return response;
        }
    }
}
