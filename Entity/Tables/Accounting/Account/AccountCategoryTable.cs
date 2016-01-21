using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Accounting
{
    public class AccountCategoryTable 
    {
        [Key]
        public int AccountCategoryId { get; set; }
        [Index("AccountCategoryCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string AccountCategoryCode { get; set; }
        [Required]
        public string AccountCategoryName { get; set; }
        public string AccountCategoryNameInLatin { get; set; }
     
        public virtual Collection<AccountSubCategoryTable> AccountSubCategoryTables { get; set; }
        
    }
}
