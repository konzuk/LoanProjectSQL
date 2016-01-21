using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Location
{
    public class LocationTypeTable 
    {
    
        [Key]
        public int LocationTypeId { get; set; }
        [Index("LocationTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string LocationTypeCode { get; set; }
        public string LocationTypeName { get; set; }
        public string LocationTypeNameInLatin { get; set; }
        public string Description { get; set; }

        public virtual Collection<LocationTable> LocationTables { get; set; }
     

    }
}
