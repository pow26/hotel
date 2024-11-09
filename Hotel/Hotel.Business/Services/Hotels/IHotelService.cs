using Hotel.Business.DTOs;
using Hotel.Common;
using Hotel.Repository.Models;

namespace Hotel.Business.Services.Hotels
{
    public interface IHotelService
    {
        Task<Response<PagingDto<HotelDto>>> Search(SearchModel model);
    }
}
