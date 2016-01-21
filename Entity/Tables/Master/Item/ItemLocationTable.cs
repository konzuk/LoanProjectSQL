using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Location;

namespace MainEntity.Tables.Item
{
    public class ItemLocationTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemLocationId { get; set; }

        [Index("ItemLocation_Index", 1, IsUnique = true), Required]
        public int ItemId { get; set; }
        public virtual ItemTable ItemTable {get; set; }

        [Index("ItemLocation_Index", 2, IsUnique = true), Required]
        public int LocationId { get; set; }
        public virtual LocationTable LocationTable { get; set; }
    }
}
