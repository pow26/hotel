using Hotel.Repository.Repositories.Repository;
using Hotel.Repository.Entities;

namespace Hotel.Repository.Repositories.Rooms
{
    public class RoomRepository : GenericRepository<Entities.Room>, IRoomRepository
    {
        public RoomRepository(HotelContext context) : base(context)
        {
        }
    }
}
