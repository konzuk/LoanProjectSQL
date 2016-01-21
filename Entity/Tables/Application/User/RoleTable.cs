using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class RoleTable 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }

        public int ApplicationFunctionId { get; set; }
        public virtual ApplicationFunctionTable ApplicationFunctionTable { get; set; }
        public int UserGroupId { get; set; }
        public virtual UserGroupTable UserGroupTable { get; set; }
       
       
    }
}
