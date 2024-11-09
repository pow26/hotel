using System;
using Hotel.Repository.Entities;
using Hotel.Repository.Repositories.Bookings;
using Hotel.Repository.Repositories.Hotels;
using Hotel.Repository.Repositories.Rooms;
using Hotel.Repository.Repositories.Users;

namespace Hotel.Repository.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        HotelContext Context { get; }
        IUserRepository UserRepository { get; }
        IHotelRepository HotelRepository { get; }
        IBookingRepository BookingRepository { get; }
        IRoomRepository RoomRepository { get; }
        int Complete();
    }
}
