using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Common;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Item;

namespace MainEntity.Tables.Journal
{
    public class JournalItemTable 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JournalItemId { get; set; }

        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; }
        [NotMapped]
        public double TotalLineInCompanyCurrency { get; set; }
        public double TotalLineInJournalCurrency { get; set; }
        public string Note { get; set; }

        public int JournalId { get; set; }
        [Required]
        public virtual JournalTable JournalTable { get; set; }

        public int? CurrencyId { get; set; }
        [ForeignKey("CurrencyId"), InverseProperty("JournalItemTables")]
        public CurrencyTable CurrencyTable { get; set; }

        public int? ContactId { get; set; }
        [ForeignKey("ContactId"), InverseProperty("JournalItemTables")]
        public virtual ContactTable ContactTable { get; set; }

        public int? ItemId { get; set; }
        [ForeignKey("ItemId"), InverseProperty("JournalItemTables")]
        public virtual ItemTable ItemTable { get; set; }

        public int? InventoryConditionId { get; set; }
        [ForeignKey("InventoryConditionId"), InverseProperty("JournalItemTables")]
        public virtual InventoryConditionTable InventoryConditionTable { get; set; }

        public int? PriceLevelId { get; set; }
        [ForeignKey("PriceLevelId"), InverseProperty("JournalItemTables")]
        public virtual PriceLevelTable PriceLevelTable { get; set; }

        public int? ExchangeRateId { get; set; }
        [ForeignKey("ExchangeRateId")]
        public virtual ExchangeRateTable ExchangeRateTable { get; set; }
        
        public bool IsHeader { get; set; }
        public virtual Collection<JournalItemAccountTable>JournalItemAccountTables { get; set; }

        public int? OriginalJournalItemId { get; set; }
        [ForeignKey("OriginalJournalItemId"), InverseProperty("ReturnJournalItemTables")]
        public virtual JournalItemTable OriginalJournalItemTable { get; set; }
        public virtual Collection<JournalItemTable> ReturnJournalItemTables { get; set; } 

        public virtual Collection<ItemSerialNumberTable> ItemSerialNumberTables { get; set; } 

        public bool IncludeVAT { get; set; }
        public double VATRate { get; set; }

  
    }
}
