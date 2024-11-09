using Hotel.Business.DTOs;
using Hotel.Business.Services.Hotels;
using Hotel.Common;
using Hotel.Repository.Entities;
using Hotel.Repository.Models;
using Hotel.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Hotel.Business.Services.Bookings
{
    public class BookingService : IBookingService
    {
        private readonly ILogger<BookingService> logger;
        private IUnitOfWork unitOfWork;
        public BookingService(IUnitOfWork unitOfWork, ILogger<BookingService> logger)
        {
            this.unitOfWork = unitOfWork;
            this.logger = logger;
        }
        /// <summary>
        /// Get room detail and RoomBookingDates to check visible/disable day on calendar
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Response<RoomDetailDto>> GetRoomDetail(RoomModel model)
        {
            var response = new Response<RoomDetailDto>();
            try
            {
                var result = await (from r in unitOfWork.Context.Rooms
                    where r.RoomId == model.RoomId && r.Section.MaxAdult >= model.MaxAdult && r.Section.MaxChildren >= model.MaxChildren && r.Section.Infants >= model.MaxInfant && r.Section.Pets >= model.MaxPet
                    select new RoomDetailDto()
                    {
                        MaxAdult = (int) r.Section.MaxAdult,
                        MaxChildren = (int) r.Section.MaxChildren,
                        Infants = (int) r.Section.Infants,
                        Pets = (int) r.Section.Pets,
                        RoomId = r.RoomId,
                        PricePerNight = (decimal) r.Section.PricePerNight,
                        RoomBookingDates = r.Bookings.Where(a => a.CheckIn >= DateTime.UtcNow).Select(s => new RoomBookingDateDto
                        {
                            CheckInDate = (DateTime) s.CheckIn,
                            CheckOutDate = (DateTime) s.CheckOut,
                        }).ToList()
                    }).FirstOrDefaultAsync();
                if (result != null) response.Data = result;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }

            return response;
        }

        public async Task<Response<bool>> Booking(BookingModel model)
        {
            var response = new Response<bool>();
            try
            {
                var booking = new Booking()
                {
                    CheckIn = model.CheckInDate,
                    CheckOut = model.CheckOutDate,
                    RoomId = model.RoomId,
                    UserId = model.UserId,
                    TotalPrice = model.TotalPrice,
                    PricePerNight = model.PricePerNight,
                    Taxes = model.Taxes,
                    Fee = model.Fee,
                    Adults = model.Adults,
                    Children = model.Children,
                    Infants = model.Infants,
                };
                await unitOfWork.BookingRepository.AddAsync(booking);
                response.Data = true;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }

            return response;
        }
    }
}
