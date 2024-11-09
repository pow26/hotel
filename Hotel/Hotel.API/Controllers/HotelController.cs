using Hotel.Business.DTOs;
using Hotel.Business.Services.Hotels;
using Hotel.Common;
using Hotel.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [ApiController]
    [Route("api/hotel")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService hotelService;
        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        [HttpPost("Search")]
        public async Task<Response<PagingDto<HotelDto>>> Search([FromBody] SearchModel model)
        {
            return await hotelService.Search(model).ConfigureAwait(false);
        }
    }
}
