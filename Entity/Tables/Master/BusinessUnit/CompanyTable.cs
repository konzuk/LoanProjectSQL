
using System.Collections.ObjectModel;
using MainEntity.Tables.Common;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Employee;

namespace MainEntity.Tables.BusinessUnit
{
    public class CompanyTable : ContactTable
    {
        string VATCode { get; set; }
        double VATRate { get; set; }

        public int? CurrencyId { get; set; }
        public virtual CurrencyTable CurrencyTable { get; set; }
        
        public virtual Collection<DepartmentTable> DepartmentTables { get; set; }
    }
}
