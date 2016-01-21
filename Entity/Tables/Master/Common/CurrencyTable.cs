using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.BusinessUnit;
using MainEntity.Tables.Item;
using MainEntity.Tables.Journal;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Common
{
    public class CurrencyTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrencyId { get; set; }
        [Index("CurrencyCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyNameInLatin { get; set; }
        public string CurrencySymbol { get; set; }

        public virtual Collection<ItemPriceTable> ItemPriceTables { get; set; } 

        public virtual Collection<ExchangeRateTable> FromExchangeRateTables { get; set; }
        public virtual Collection<ExchangeRateTable> ToExchangeRateTables { get; set; }
        
        public virtual Collection<JournalTable> JournalTables { get; set; }
        public virtual Collection<JournalItemTable> JournalItemTables { get; set; }

        [InverseProperty("CreatedCurrencyTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedCurrencyTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
