using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Item
{
    public class PackageUnitItemTable 
    {
       
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PackageUnitItemId { get; set; }

        public int? SmallUnitId { get; set; }
        [ForeignKey("SmallUnitId"), InverseProperty("SmallPackageUnitItemTables")]
        public virtual UnitTable SmallUnitTable { get; set; }

        private double _qty = 1;
        public double Qty { get { return _qty; } set { _qty = value; } }

        public int PackageUnitId { get; set; }
        [Required, ForeignKey("PackageUnitId"), InverseProperty("PackageUnitItemTables")]
        public virtual PackageUnitTable PackageUnitTable { get; set; }
        

    }
}
