using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Journal;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Common
{
    public class ExchangeRateTable : TableBase
    {
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExchangeRateId { get; set; }
    
        [Index("ExchangeRate_Index", 1, IsUnique = true)]
        public int? FromCurrencyId { get; set; }
        [ForeignKey("FromCurrencyId"), InverseProperty("FromExchangeRateTables")]
        public virtual CurrencyTable FromCurrencyTable { get; set; }
        
        [Index("ExchangeRate_Index", 2, IsUnique = true)]
        public int? ToCurrencyId { get; set; }
        [ForeignKey("ToCurrencyId"), InverseProperty("ToExchangeRateTables")]
        public virtual CurrencyTable ToCurrencyTable { get; set; }
        
        public double BitRate { get; set; }
        public double AskRate { get; set; }

        //[Index("ExchangeRate_Index", 3, IsUnique = true)]
        //public int? JournalExchangeRateId { get; set; }
        //public virtual JournalExchangeRateTable JournalExchangeRateTable { get; set; }

        //[Index("ExchangeRate_Index", 4, IsUnique = true)]
        //public int? JournalItemExchangeRateId { get; set; }
        //public virtual JournalItemExchangeRateTable JournalItemExchangeRateTable { get; set; }

        //[Index("ExchangeRate_Index", 5, IsUnique = true)]
        //public int? PaymentItemExchangeRateId { get; set; }
        //public virtual PaymentItemExchangeRateTable PaymentItemExchangeRateTable { get; set; }

        public virtual Collection<JournalTable> JournalTables { get; set; }
        public virtual Collection<JournalItemTable> JournalItemTables { get; set; }
        public virtual Collection<PaymentItemTable> PaymentItemTables { get; set; } 
        
        
        [InverseProperty("CreatedExchangeRateTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedExchangeRateTables")]
        public override UserTable ModefiedBy { get; set; }

    }
}
