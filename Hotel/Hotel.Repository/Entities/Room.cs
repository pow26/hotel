using System;
using System.Collections.Generic;

namespace Hotel.Repository.Entities;

public partial class Room
{
    public int RoomId { get; set; }

    public string? Name { get; set; }

    public int? HotelId { get; set; }

    public bool? IsReserved { get; set; }

    public int? SectionId { get; set; }

    public bool? Smoke { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Hotel? Hotel { get; set; }

    public virtual Section? Section { get; set; }
}
