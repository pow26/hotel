using System;
using System.Collections.Generic;

namespace Hotel.Repository.Entities;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string? Name { get; set; }

    public int LocationId { get; set; }

    public string? Description { get; set; }
    public TimeSpan CheckInTime { get; set; }
    public TimeSpan CheckOutTime { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
