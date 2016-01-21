using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class ItemSerialNumberTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemSerialNumberId { get; set; }
        
        [Index("ItemSerialNumber_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string SerialNumber { get; set; }

        [Index("ItemSerialNumber_Index", 2, IsUnique = true), Required]
        public int JournalItemId { get; set; }
        public virtual JournalItemTable JournalItemTable { get; set; }
    }
}
