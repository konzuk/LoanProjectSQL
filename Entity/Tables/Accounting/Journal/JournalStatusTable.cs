using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class JournalStatusTable
    {
        [Key]
        public int JournalStatusId { get; set; }
        [Index("JournalStatusCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string JournalStatusCode { get; set; }
        public string JournalStatusName { get; set; }
        public string JournalStatusNameInLatin { get; set; }

        public virtual Collection<JournalTable> JournalTables { get; set; } 
    }
}
