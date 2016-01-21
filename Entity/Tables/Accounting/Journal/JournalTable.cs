using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Accounting;
using MainEntity.Tables.Common;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Item;
using MainEntity.Tables.Location;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Journal
{
    public class JournalTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JournalId { get; set; }
        [Index("JournalCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string JournalCode { get; set; }
        public double TotalInCompanyCurrency { get; set; }
        public double TotalInJournalCurrency { get; set; }
        public string Note { get; set; }

        private DateTime _journalUtcDateTime = DateTime.UtcNow;
        public DateTime JournalUctDateTime {
            get { return _journalUtcDateTime; }
            set { _journalUtcDateTime = value; }
        }
        [NotMapped]
        public DateTime JournalLocalDateTime {
            get { return _journalUtcDateTime.ToLocalTime(); }
            set { _journalUtcDateTime = value.ToUniversalTime(); }
        }

        //Default is company currency
        public int? CurrencyId { get; set; }
        [ForeignKey("CurrencyId"), InverseProperty("JournalTables")]
        public virtual CurrencyTable CurrencyTable { get; set; }

        public int? ContactId { get; set; }
        [ForeignKey("ContactId"), InverseProperty("JournalTables")]
        public virtual ContactTable ContactTable { get; set; }


        public int? WarehouseId { get; set; }
        [ForeignKey("WarehouseId"), InverseProperty("JournalTables")]
        public virtual WarehouseTable WarehouseTable { get; set; }

        public int? ExchangeRateId { get; set; }
        [ForeignKey("ExchangeRateId")]
        public virtual ExchangeRateTable ExchangeRateTable { get; set; }

        public virtual Collection<JournalItemTable> JournalItemTables { get; set; }
        
        public virtual Collection<PaymentTable> PaymentSettlementTables { get; set; } //Payment Settlement list
        public virtual Collection<PaymentItemTable> PaymetItemTables { get; set; } 

        public int? JournalStatusId { get; set; }
        public virtual JournalStatusTable JournalStatusTable { get; set; }

        /*Use to create key for transfer and production*/
        //[Index("JournalCode_Index", 2, IsUnique = true), Required]
        //public int InventoryTypeId { get; set; }
        //public virtual InventoryTypeTable InventoryTypeTable { get; set; }

        [Index("JournalCode_Index", 2, IsUnique = true), Required]
        public int TransactionTypeId { get; set; }
        public virtual TransactionTypeTable TransactionTypeTable { get; set; }

        public int AccountId { get; set; }
        public virtual AccountTable AccountTable { get; set; }

        public bool IsDebit { get; set; }

        //public int? ItemId { get; set; }
        //public virtual ItemTable ItemTable { get; set; }
        public virtual Collection<ItemTable> ItemTables { get; set; } 

        public virtual Collection<JournalItemAccountTypeTable> JouranlItemAccountTypeTables { get; set; }

        [InverseProperty("CreatedJournalTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedJournalTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
