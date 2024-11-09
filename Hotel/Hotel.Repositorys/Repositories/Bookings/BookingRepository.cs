using Hotel.Repository.Repositories.Repository;
using Hotel.Repository.Entities;
using Hotel.Repository.Repositories.Hotels;

namespace Hotel.Repository.Repositories.Bookings
{
    public class BookingRepository : GenericRepository<Entities.Booking>, IBookingRepository
    {
        public BookingRepository(HotelContext context) : base(context)
        {
        }
    }
}
