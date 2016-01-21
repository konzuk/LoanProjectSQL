using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Accounting
{
    public class AccountSubCategoryTable 
    {
        [Key]
        public int AccountSubCategoryId { get; set; }
        [Index("AccountSubCategoryCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string AccountSubCategoryCode { get; set; }
        [Required]
        public string AccountSubCategoryName { get; set; }
        public string AccountSubCategoryNameInLatin { get; set; }
     
        public int AccountCategoryId { get; set; }
        public AccountCategoryTable AccountCategoryTable { get; set; }

        public virtual Collection<AccountTypeTable> AccountSubCategoryTables { get; set; }
        
    }
}
