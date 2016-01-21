using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Item
{
    public class ItemSetItemTable
    {
        public ItemSetItemTable()
        {
            Qty = 1;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemSetItemId { get; set; }

        public int? ItemId { get; set; }
        public virtual ItemTable ItemTable { get; set; }
        public int? ItemSetId { get; set; }
        [ForeignKey("ItemSetId"), InverseProperty("ItemSetItem1Tables")]
        public virtual ItemSetTable ItemSetTable { get; set; }
        public double Qty { get; set; }

    }
}
