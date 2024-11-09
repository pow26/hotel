using Hotel.Repository.Entities;
using Hotel.Repository.Repositories.Repository;

namespace Hotel.Repository.Repositories.Hotels
{
    public class HotelRepository : GenericRepository<Entities.Hotel>, IHotelRepository
    {
        public HotelRepository(HotelContext context) : base(context)
        {
        }
    }
}
