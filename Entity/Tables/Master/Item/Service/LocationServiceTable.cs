using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Location;

namespace MainEntity.Tables.Item.Service
{
    public class LocationServiceTable : ServiceTable
    {
        //[Index("ItemCode_Index", 3, IsUnique = true)]
        public int? FromLocationId { get; set; }
        [ForeignKey("FromLocationId"), InverseProperty("FromLocationServiceTables")]
        public virtual LocationTable FromLocationTable { get; set; }

        //[Index("ItemCode_Index", 4, IsUnique = true)]
        public int? ToLocationId { get; set; }
        [ForeignKey("ToLocationId"), InverseProperty("ToLocationServiceTables")]
        public virtual LocationTable ToLocationTable { get; set; }
    }
}
