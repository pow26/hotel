using System;
using System.Collections.Generic;

namespace Hotel.Repository.Entities;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? RoomId { get; set; }

    public DateTime? CheckIn { get; set; }

    public DateTime? CheckOut { get; set; }

    public decimal? PricePerNight { get; set; }
    public decimal? TotalPrice { get; set; }
    public decimal? Taxes { get; set; }
    public decimal? Fee { get; set; }

    public int? UserId { get; set; }
    public int? Adults { get; set; }
    public int? Children { get; set; }
    public int? Infants { get; set; }

    public virtual Room? Room { get; set; }

    public virtual User? User { get; set; }
}
