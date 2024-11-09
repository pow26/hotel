using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel.Common
{
    public class Constants
    {
        public const string CheckInMessage = "Check in date should be greater than the current date";
        public const string CheckOutMessage = "Check out date should be greater than the check in date";
        public const string ReservationNotAvailable = "Reservation date not available";
        public const string UserNotFound = "User not found";
        public const string RoomNotFound = "Room not found";
    }
}
