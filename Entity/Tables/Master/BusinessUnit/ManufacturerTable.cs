using System.Collections.ObjectModel;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Item;

namespace MainEntity.Tables.BusinessUnit
{
    public class ManufacturerTable : ContactTable
    {
        public virtual Collection<GoodsTable> GoodsTables { get; set; } 
    }
}
