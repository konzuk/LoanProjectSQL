using System;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.BusinessUnit;

namespace MainEntity.Tables.Item
{
    public class GoodsTable : ItemTable
    {
       
        public string Barcode { get; set; }
        public DateTime? MenDate { get; set; }
        public DateTime? ExpDate { get; set; }

        public int? ManufacturerId { get; set; }
        [ForeignKey("ManufacturerId"), InverseProperty("GoodsTables")]
        public virtual ManufacturerTable ManufacturerTable { get; set; }
    }
}
