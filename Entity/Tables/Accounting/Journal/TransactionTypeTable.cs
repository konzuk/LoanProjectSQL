using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class TransactionTypeTable
    {
        [Key]
        public int TransactionTypeId { get; set; }
        [Index("TransactionTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string TransactionTypeCode { get; set; }
        public string TransactionTypeName { get; set; }
        public string TransactionTypeNameInLatin { get; set; }

        public int InventoryTypeId { get; set; }
        public virtual InventoryTypeTable InventoryTypeTable { get; set; }

        public virtual Collection<JournalTable> JournalTables { get; set; } 
    }
}
