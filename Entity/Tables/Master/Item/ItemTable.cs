using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Accounting;
using MainEntity.Tables.Journal;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Item
{
    public class ItemTable : TableBase
    {
       
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }
        [Index("ItemCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemNameInLatin { get; set; }
        public string PhotoPath { get; set; }

        public virtual Collection<ItemLocationTable> ItemLocationTables { get; set; }
        public int? ItemCategoryId { get; set; }
        public virtual ItemCategoryTable ItemCategoryTable { get; set; }
        
        public virtual Collection<ItemPriceTable> ItemPriceTables { get; set; }

        public int ItemTypeId { get; set; }
        public virtual ItemTypeTable ItemTypeTable { get; set; }
        
        public int? UnitId { get; set; }
        public virtual UnitTable UnitTable { get; set; }
        public string Description { get; set; }

        public virtual Collection<ItemSetItemTable> ItemSetItemTables { get; set; }
        public virtual Collection<JournalItemTable> JournalItemTables { get; set; }

        public int? IncomeAccountId { get; set; }
        [ForeignKey("IncomeAccountId"), InverseProperty("IncomeItemTables")]
        public virtual AccountTable IncomeAccountTable { get; set; }

        public int? ExpenseAccountId { get; set; }
        [ForeignKey("ExpenseAccountId"), InverseProperty("ExpenseItemTables")]
        public virtual AccountTable ExpenseAccountTable { get; set; }

        public int? CogsAccountId { get; set; }
        [ForeignKey("CogsAccountId"), InverseProperty("CogsItemTables")]
        public virtual AccountTable CogsAccountTable { get; set; }

        public int? InventoryAccountId { get; set; }
        [ForeignKey("InventoryAccountId"), InverseProperty("InventoryItemTables")]
        public virtual AccountTable InventoryAccountTable { get; set; }

        public int? JournalId { get; set; }
        public virtual JournalTable JournalTable { get; set; }

        [InverseProperty("CreatedItemTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedItemTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
