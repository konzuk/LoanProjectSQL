using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Journal;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Item
{
    public class PriceLevelTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PriceLevelId { get; set; }
        [Index("PriceLevelCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string PriceLevelCode { get; set; }
        public string PriceLevelName { get; set; }
        public string PriceLevelNameInLatin { get; set; }
   
        public virtual Collection<ItemPriceTable> ItemPriceTables { get; set; }

        public int PriceLevelTypeId { get; set; }
        [ForeignKey("PriceLevelTypeId")]
        public virtual PriceLevelTypeTable PriceLevelTypeTable { get; set; }
        public double AddValue { get; set; }

        public int? BasePriceLevelId { get; set; }
        [ForeignKey("BasePriceLevelId"), InverseProperty("PriceLevelTables")]
        public virtual PriceLevelTable BasePriceLevelTable { get; set; } 
        public virtual Collection<PriceLevelTable> PriceLevelTables { get; set; }

        public virtual Collection<JournalItemTable> JournalItemTables { get; set; }
        public virtual Collection<ContactTable> ContactTables { get; set; }

        [InverseProperty("CreatedPriceLevelTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedPriceLevelTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
