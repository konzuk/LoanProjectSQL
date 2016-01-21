using System;
using System.Collections.ObjectModel;
using MainEntity.Tables.Common;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Employee;

namespace MainEntity.Tables.BusinessUnit
{
    public class BusinessUnitTable : ContactTable
    {
        public int? CurrencyId { get; set; }
        public virtual CurrencyTable CurrencyTable { get; set; }
       
    }
}
