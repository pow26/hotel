using Hotel.Business.DTOs;
using Hotel.Business.Services.Bookings;
using Hotel.Common;
using Hotel.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [ApiController]
    [Route("api/booking")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService bookingService;
        public BookingController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        [HttpPost("GetRoomDetail")]
        public async Task<Response<RoomDetailDto>> GetRoomDetail([FromBody]RoomModel model)
        {
            return await bookingService.GetRoomDetail(model).ConfigureAwait(false);
        }
        
        [HttpPost("Booking")]
        public async Task<Response<bool>> Booking([FromBody] BookingModel model)
        {
            return await bookingService.Booking(model).ConfigureAwait(false);
        }
    }
}
