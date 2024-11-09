using System.ComponentModel;

namespace Hotel.Repository.Models
{
    public class RoomModel
    {
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        [DefaultValue(1)]
        public int MaxAdult { get; set; }
        public int MaxChildren { get; set; }
        public int MaxInfant { get; set; }
        public int MaxPet { get; set; }
    }
}
