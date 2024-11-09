﻿using System.ComponentModel;

namespace Hotel.Repository.Models
{
    public class SearchModel
    {
        [DefaultValue(10)]
        public int PageSize { get; set; }
        [DefaultValue(1)]
        public int PageNumber { get; set; }
        public int LocationId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        [DefaultValue(2)]
        public int MaxAdult { get; set; }
        public int MaxChildren { get; set; }
        public int MaxInfant { get; set; }
        public int MaxPet { get; set; }
    }
}
