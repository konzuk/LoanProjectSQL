using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Item;
using MainEntity.Tables.Journal;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Accounting
{
    public class AccountTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        [Index("AccountCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string AccountNameInLatin { get; set; }
        public string AccountFullName { get; set; }
        public string AccountFullNameInLatin { get; set; }

        public int AccountTypeId { get; set; }
        public virtual AccountTypeTable AccountTypeTable { get; set; }

        public bool IsContra { get; set; }

        public virtual Collection<JournalTable> JournalTables { get; set; }
        public virtual Collection<JournalItemAccountTable> JournalItemAccountTables { get; set; }
        
        public virtual Collection<ItemTable> IncomeItemTables { get; set; }
        public virtual Collection<ItemTable> ExpenseItemTables { get; set; }
        public virtual Collection<ItemTable> CogsItemTables { get; set; }
        public virtual Collection<ItemTable> InventoryItemTables { get; set; }

        [InverseProperty("CreatedAccountTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedAccountTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
