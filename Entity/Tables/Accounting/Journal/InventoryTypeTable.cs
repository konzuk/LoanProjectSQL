using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class InventoryTypeTable
    {
        [Key]
        public int InventoryTypeId { get; set; }
        [Index("InventoryTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string InventoryTypeCode { get; set; }
        public string InventoryTypeName { get; set; }
        public string InventoryTypeNameInLatin { get; set; }

        public virtual Collection<TransactionTypeTable> TransactionTypeTables { get; set; } 
    }
}
