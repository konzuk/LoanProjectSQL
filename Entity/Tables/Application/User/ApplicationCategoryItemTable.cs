using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class ApplicationCategoryItemTable 
    {
        [Key, Column(Order = 1), ForeignKey("ApplicationCategoryTable")]
        public int ApplicationCategoryId { get; set; }
        public virtual ApplicationCategoryTable ApplicationCategoryTable { get; set; }

        [Key, Column(Order = 2), ForeignKey("ApplicationTable")]
        public int ApplicationId { get; set; }
        public virtual ApplicationTable ApplicationTable { get; set; }
       
    }
}
