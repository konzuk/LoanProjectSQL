using System.Collections.ObjectModel;

namespace MainEntity.Tables.Item
{
    public class ItemSetTable : ItemTable
    {
        public virtual Collection<ItemSetItemTable> ItemSetItem1Tables { get; set; }
    }
}
