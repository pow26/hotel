using System;
using System.Collections.Generic;

namespace Hotel.Repository.Entities;

public partial class Location
{
    public int LocationId { get; set; }

    public string? Region { get; set; }

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}
