namespace Hotel.Business.DTOs
{
    public class RoomDetailDto
    {
        public int RoomId { get; set; }
        public int MaxAdult { get; set; }
        public int MaxChildren { get; set; }
        public int Infants { get; set; }
        public int Pets { get; set; }
        public decimal PricePerNight { get; set; }
        public List<RoomBookingDateDto> RoomBookingDates { get; set; }
    }
}
