using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Item
{
    public  class UnitTable: TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UnitId { get; set; }
        [Index("UnitCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string UnitNameInLatin { get; set; }
        
        public virtual Collection<ItemTable> ItemTables { get; set; }

        [InverseProperty("CreatedUnitTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedUnitTables")]
        public override UserTable ModefiedBy { get; set; }

    }
}
