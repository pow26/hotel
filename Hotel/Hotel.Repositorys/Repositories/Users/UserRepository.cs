using Hotel.Repository.Repositories.Repository;
using Hotel.Repository.Entities;

namespace Hotel.Repository.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(HotelContext context) : base(context)
        {
        }
    }
}
