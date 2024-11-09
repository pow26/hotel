namespace Hotel.Business.DTOs
{
    public class HotelDto
    {
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomName { get; set; }
        public decimal PricePerNight { get; set; }
    }
}
