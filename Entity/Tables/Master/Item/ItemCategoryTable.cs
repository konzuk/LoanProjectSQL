using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Item
{
    public class ItemCategoryTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemCategoryId { get; set; }
        [Index("ItemCategoryCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string ItemCategoryCode { get; set; }
        public string ItemCategoryName { get; set; }
        public string ItemCategoryNameInLatin { get; set; }

        public int? ParentItemCategoryId { get; set; }
        [ForeignKey("ParentItemCategoryId"), InverseProperty("ItemCategoryTables")]
        public virtual ItemCategoryTable ParentItemCategoryTable { get; set; }
        public virtual Collection<ItemCategoryTable> ItemCategoryTables { get; set; }
        public virtual Collection<ItemTable> ItemTables { get; set; }

        [InverseProperty("CreatedItemCategoryTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedItemCategoryTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
