using Hotel.Repository.Entities;
using Hotel.Repository.Repositories.Bookings;
using Hotel.Repository.Repositories.Hotels;
using Hotel.Repository.Repositories.Rooms;
using Hotel.Repository.Repositories.Users;

namespace Hotel.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelContext _context;
        public HotelContext Context { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        public IHotelRepository HotelRepository { get; private set; }
        public IBookingRepository BookingRepository { get; private set; }
        public IRoomRepository RoomRepository { get; private set; }

        public UnitOfWork(HotelContext context)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
            HotelRepository = new HotelRepository(_context);
            BookingRepository = new BookingRepository(_context);
            RoomRepository = new RoomRepository(_context);
            Context = _context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
