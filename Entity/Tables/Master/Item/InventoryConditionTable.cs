using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Journal;

namespace MainEntity.Tables.Item
{
    public class InventoryConditionTable
    {
        [Key]
        public int InventoryConditionId { get; set; }
        [Index("InventoryConditionCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string InventoryConditionCode { get; set; }
        public string InventoryConditionName { get; set; }
        public string InventoryConditionNameInLatin { get; set; }

        public virtual Collection<JournalItemTable> JournalItemTables { get; set; }
    }
}
