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
        public int MaxAdult { get; set; }

        public int MaxChildren { get; set; }

        public int Infants { get; set; }

        public int Pets { get; set; }
    }
}
