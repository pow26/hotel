using Hotel.Business.Services.Bookings;
using Hotel.Repository.Repositories;
using Microsoft.Extensions.Logging;

namespace Hotel.Business.Services.Rooms
{
    public class RoomService : IRoomService
    {
        private readonly ILogger<RoomService> logger;
        private IUnitOfWork unitOfWork;
        public RoomService(IUnitOfWork unitOfWork, ILogger<RoomService> logger)
        {
            this.unitOfWork = unitOfWork;
            this.logger = logger;
        }
    }
}
