using Hotel.Business.DTOs;
using Hotel.Common;
using Hotel.Repository.Models;

namespace Hotel.Business.Services.Bookings
{
    public interface IBookingService
    {
        Task<Response<RoomDetailDto>> GetRoomDetail(RoomModel model);
        Task<Response<bool>> Booking(BookingModel model);
    }
}
