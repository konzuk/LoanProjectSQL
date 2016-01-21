using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class JournalTypeTable
    {
        [Key]
        public int JournalTypeId { get; set; }
        [Index("JournalTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string JournalTypeCode { get; set; }
        public string JournalTypeName { get; set; }
        public string JournalTypeNameInLatin { get; set; }

        public virtual Collection<JournalItemAccountTypeTable> JouranlItemAccountTypeTables { get; set; } 
    }
}
