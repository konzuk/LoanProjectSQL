using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Item
{
    public class ItemTypeTable
    {
        [Key]
        public int ItemTypeId { get; set; }
        [Index("ItemTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string ItemTypeCode { get; set; }
        public string ItemTypeName { get; set; }
        public string ItemTypeNameInLatin { get; set; }

        public virtual Collection<ItemTable> ItemTables { get; set; }

       
    }
}
