using System;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Repository.Models
{
    public class SearchModel
    {
        [Range(1, int.MaxValue)]
        public int PageSize { get; set; }

        [Range(0, int.MaxValue)]
        public int PageNumber { get; set; }
        public int LocationId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int MaxAdult { get; set; }
        public int MaxChildren { get; set; }
        public int MaxInfant { get; set; }
        public int MaxPet { get; set; }
    }
}
