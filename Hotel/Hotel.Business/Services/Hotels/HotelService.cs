﻿using Hotel.Business.DTOs;
using Hotel.Common;
using Hotel.Repository.Entities;
using Hotel.Repository.Models;
using Hotel.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Hotel.Business.Services.Hotels
{
    public class HotelService : IHotelService
    {
        private readonly ILogger<HotelService> logger;
        private IUnitOfWork unitOfWork;
        public HotelService(IUnitOfWork unitOfWork, ILogger<HotelService> logger)
        {
            this.unitOfWork = unitOfWork;
            this.logger = logger;
        }

        public async Task<Response<PagingDto<HotelDto>>> Search(SearchModel model)
        {
            var response = new Response<PagingDto<HotelDto>>();
            try
            {
                var query = (from r in unitOfWork.Context.Rooms
                where r.Hotel.LocationId == model.LocationId && r.Section.MaxAdult >= model.MaxAdult && r.Section.MaxChildren >= model.MaxChildren && r.Section.Infants >= model.MaxInfant && r.Section.Pets >= model.MaxPet && r.Bookings.All(a => a.CheckOut <= model.CheckInDate || a.CheckIn >= model.CheckOutDate)
                select new HotelDto()
                {
                    HotelId = r.Hotel.HotelId,
                    Location = r.Hotel.Location.Region,
                    Name = r.Hotel.Name,
                    Description = r.Hotel.Description,
                    RoomTypeName = r.Section.Name,
                    RoomName = r.Name,
                    RoomId = r.RoomId,
                    PricePerNight = (decimal) r.Section.PricePerNight
                });
                var total = await query.CountAsync();
                var result = await query.Skip((model.PageNumber - 1) * model.PageSize).Take(model.PageSize).ToListAsync();

                response.Data = new PagingDto<HotelDto>(result, model.PageNumber, model.PageSize, total);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }

            return response;
        }
    }
}