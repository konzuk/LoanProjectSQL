using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Common;

namespace MainEntity.Tables.Item
{
    public class ItemPriceTable
    {
    
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemPriceId { get; set; }

        [Index("ItemPrice_Index", 1, IsUnique = true), Required]
        public int ItemId { get; set; }
        public virtual ItemTable ItemTable { get; set; }
        
        [Index("ItemPrice_Index", 2, IsUnique = true), Required]
        public int PriceLevelId { get; set; }
        public virtual PriceLevelTable PriceLevelTable { get; set; }
        public double Price { get; set; }

        [Index("ItemPrice_Index", 3, IsUnique = true), Required]
        public int CurrencyId { get; set; }
        public virtual CurrencyTable CurrencyTable { get; set; }

    }
}
