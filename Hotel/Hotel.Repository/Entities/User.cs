﻿using System;
using System.Collections.Generic;

namespace Hotel.Repository.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
