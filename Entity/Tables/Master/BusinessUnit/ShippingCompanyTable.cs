using System.Collections.ObjectModel;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Journal;

namespace MainEntity.Tables.BusinessUnit
{
    public class ShippingCompanyTable : ContactTable
    {
        public virtual Collection<ShippingInfoTable> ShippingInfoTables { get; set; } 
    }
}
