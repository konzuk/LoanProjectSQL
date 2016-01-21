using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class StockTansferTable 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockTransferId { get; set; }

        public int? FromJournalId { get; set; }
        [ForeignKey("FromJournalId"), InverseProperty("FromStockTansferTables")]
        public virtual GoodsMovementTable FromJournalTable { get; set; }

        public int? ToJournalId { get; set; }
        [ForeignKey("ToJournalId"), InverseProperty("ToStockTansferTables")]
        public virtual GoodsMovementTable ToJournalTable { get; set; }
      
        public bool IsProduction { get; set; }
    }
}
