using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Accounting
{
    public class AccountTypeTable 
    {
        [Key]
        public int AccountTypeId { get; set; }
        [Index("AccountTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string AccountTypeCode { get; set; }
        [Required]
        public string AccountTypeName { get; set; }
        public string AccountTypeNameInLatin { get; set; }
     
        public int AccountSubCategoryId { get; set; }
        public virtual AccountSubCategoryTable AccountSubCategoryTable { get; set; }
        
        public virtual Collection<AccountTable> AccountTables { get; set; }
    
    }
}
