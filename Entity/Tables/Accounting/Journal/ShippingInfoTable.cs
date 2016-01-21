using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using MainEntity.Tables.BusinessUnit;

namespace MainEntity.Tables.Journal
{
    public class ShippingInfoTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShippingInfoId { get; set; }

        public int GoodsMovementId { get; set; }
        [ForeignKey("GoodsMovementId")]
        public GoodsMovementTable GoodsMovementTable { get; set; }

        public int ShippingCompanyId { get; set; }
        [ForeignKey("ShippingCompanyId"), InverseProperty("ShippingInfoTables")]
        public virtual ShippingCompanyTable ShippingCompanyTable { get; set; }

        public string DriverName { get; set; }
        public string DriverPhone { get; set; }
        public string LicensePlate { get; set; }

    }
}
