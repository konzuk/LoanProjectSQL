using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Item;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Location
{
    public class LocationTable : TableBase
    {
        
        [Key]
        public int LocationId { get; set; }
        [Index("LocationCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string LocationNameInLatin { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }

        public int? LocationTypeId { get; set; }
        public virtual LocationTypeTable LocationTypeTable { get; set; }

        public int? WarehouseId { get; set; }  
        public virtual WarehouseTable WarehouseTable { get; set; }

        public int? ParentLocationId { get; set; }
        [ForeignKey("ParentLocationId"), InverseProperty("LocationTables")]
        public virtual LocationTable ParentLocationTable { get; set; }
        public virtual Collection<LocationTable> LocationTables { get; set; } 

        public virtual Collection<ItemLocationTable> ItemLocationTables { get; set; } 
        
        //public virtual Collection<LocationServiceTable> FromLocationServiceTables { get; set; }
        //public virtual Collection<LocationServiceTable> ToLocationServiceTables { get; set; }
        //public virtual Collection<HotelServiceTable> HotelServiceTables { get; set; }


        [InverseProperty("CreatedLocationTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedLocationTables")]
        public override UserTable ModefiedBy { get; set; }

       
    }
}
