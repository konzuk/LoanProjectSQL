using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Accounting;

namespace MainEntity.Tables.Journal
{
    public class JournalItemAccountTable 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JournalItemAccountId { get; set; }

        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        [NotMapped]
        public double TotalLineInCompanyCurrency { get; set; }
        public double TotalLineInJournalCurrency { get; set; }
        
        public int? JournalItemId { get; set; }
        [ForeignKey("JournalItemId"), InverseProperty("JournalItemAccountTables")]
        public virtual JournalItemTable JournalItemTable { get; set; }

        public int? AccountId { get; set; }
        [ForeignKey("AccountId"), InverseProperty("JournalItemAccountTables")]
        public virtual AccountTable AccountTable { get; set; }

        public bool IsDebit { get; set; }

        //public int? JournalItemAccountTypeId { get; set; }
        //public JournalItemAccountTypeTable JournalItemAccountTypeTable { get; set; }
        public virtual Collection<JournalItemAccountTypeTable> JournalItemAccountTypeTables { get; set; } 
    }
}
