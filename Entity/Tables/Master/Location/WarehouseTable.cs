using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Journal;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Location
{
    public class WarehouseTable : TableBase
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WarehouseId { get; set; }
        [Index("WarehouseCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseNameInLatin { get; set; }
        public string Description { get; set; }

        public virtual Collection<LocationTable> LocationTables { get; set; } 
        public virtual Collection<JournalTable> JournalTables { get; set; }

        [InverseProperty("CreatedWarehouseTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedWarehouseTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
