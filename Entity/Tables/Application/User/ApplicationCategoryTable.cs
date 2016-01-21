using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class ApplicationCategoryTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationCategoryId { get; set; }
        [Index("ApplicationCategoryCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string ApplicationCategoryCode { get; set; }
        public string ApplicationCategoryName { get; set; }
        public string ApplicationCategoryNameInLatin { get; set; }

        public virtual Collection<ApplicationCategoryItemTable> ApplicationCategoryItemTables { get; set; }

        [InverseProperty("CreatedApplicationCategoryTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedApplicationCategoryTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
