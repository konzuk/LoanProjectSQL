using System;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Location;

namespace MainEntity.Tables.Item.Service
{
    public class ServiceLocationPriceTable : PriceListTable
    {

        [Index("PriceList_Index", 5, IsUnique = true)]
        public int? LocationId { get; set; }
        public virtual LocationTable LocationTable { get; set; }

    }
}
