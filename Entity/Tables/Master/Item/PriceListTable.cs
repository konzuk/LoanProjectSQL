using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Common;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Item
{
    public class PriceListTable : TableBase
    {
    
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PriceListId { get; set; }

        private DateTime _utcDateTime = DateTime.UtcNow;
        [Index("PriceList_Index", 1, IsUnique = true)]
        public DateTime UtcPriceDateTime {
            get { return _utcDateTime; }
            set { _utcDateTime = value; }
        }
        [NotMapped]
        public DateTime PriceDateTime {
            get { return _utcDateTime.ToLocalTime(); }
            set { _utcDateTime = value.ToUniversalTime(); }
        }

        [Index("PriceList_Index", 2, IsUnique = true)]
        public int ItemId { get; set; }
        public virtual ItemTable ItemTable { get; set; }

        [Index("PriceList_Index", 3, IsUnique = true)]
        public int UnitId { get; set; }
        public virtual UnitTable UnitTable { get; set; }
        public double SellingPrice { get; set; }

        [Index("PriceList_Index", 4, IsUnique = true)]
        public int CurrencyId { get; set; }
        public virtual CurrencyTable CurrencyTable { get; set; }

        [InverseProperty("CreatedPriceListTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedPriceListTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
