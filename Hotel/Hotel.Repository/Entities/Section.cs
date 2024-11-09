using System;
using System.Collections.Generic;

namespace Hotel.Repository.Entities;

public partial class Section
{
    public int SectionId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? PricePerNight { get; set; }

    public string? RoomType { get; set; }

    public byte? MaxAdult { get; set; }

    public byte? MaxChildren { get; set; }

    public byte? Infants { get; set; }

    public byte? Pets { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
