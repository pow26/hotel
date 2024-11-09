namespace Hotel.Repository.Models
{
    public class BookingModel
    {
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public decimal Taxes { get; set; }
        public decimal Fee { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal PricePerNight { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int Infants { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
