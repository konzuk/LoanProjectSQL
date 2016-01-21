using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class GoodsMovementTable : JournalTable
    {
        public bool IsStockIn { get; set; }

        public virtual Collection<StockTansferTable> FromStockTansferTables { get; set; }
        public virtual Collection<StockTansferTable> ToStockTansferTables { get; set; } 

        //public int? ShippingInfoId { get; set; }
        //public virtual ShippingInfoTable ShippingInfoTable { get; set; }
        public virtual Collection<ShippingInfoTable> ShippingInfoTables { get; set; } 
    }
}
