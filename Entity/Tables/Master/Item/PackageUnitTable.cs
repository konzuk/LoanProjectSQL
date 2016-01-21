using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace MainEntity.Tables.Item
{
    public class PackageUnitTable: UnitTable
    {


        public virtual Collection<PackageUnitItemTable> PackageUnitItemTables { get; set; }

        public virtual UnitTable SmallestUnitTable {
            get
            {
                var packageUnitItemTable = PackageUnitItemTables.FirstOrDefault(s => s.PackageUnitId == UnitId);

                return packageUnitItemTable==null ? this : 
                       packageUnitItemTable.SmallUnitTable is PackageUnitTable ? (packageUnitItemTable.SmallUnitTable as PackageUnitTable).SmallestUnitTable : packageUnitItemTable.SmallUnitTable;
            }
        }

        public double SmallestQty()
        {
            var packageUnitItemTable = PackageUnitItemTables.FirstOrDefault(s => s.PackageUnitId == UnitId);

            return packageUnitItemTable == null ? 1 : packageUnitItemTable.SmallUnitTable is PackageUnitTable ?  
                   packageUnitItemTable.Qty * (packageUnitItemTable.SmallUnitTable as PackageUnitTable).SmallestQty() : packageUnitItemTable.Qty;
        }

    }
}
