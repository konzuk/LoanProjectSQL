using System;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Location;

namespace MainEntity.Tables.Item.Service
{
    public class HotelServiceTable : ServiceTable
    {
        public int? LocationId { get; set; }
        [ForeignKey("LocationId"), InverseProperty("HotelServiceTables")]
        public virtual LocationTable LocationTable { get; set; }

        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string ContactAddress { get; set; }
    }
}
