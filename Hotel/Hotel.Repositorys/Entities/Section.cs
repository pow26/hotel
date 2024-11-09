//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.Repositorys.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Section()
        {
            this.Bookings = new HashSet<Booking>();
            this.Rooms = new HashSet<Room>();
        }
    
        public int SectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> PricePerNight { get; set; }
        public string RoomType { get; set; }
        public Nullable<byte> MaxAdult { get; set; }
        public Nullable<byte> MaxChildren { get; set; }
        public Nullable<byte> Infants { get; set; }
        public Nullable<byte> Pets { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}