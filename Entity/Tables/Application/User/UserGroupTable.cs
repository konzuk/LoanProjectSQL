using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class UserGroupTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserGroupId { get; set; }
        [Index("UserGroupCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string UserGroupCode { get; set; }
        public string UserGroupName { get; set; }
        public string UserGroupNameInLatin { get; set; }

        public virtual Collection<UserTable> UserTables { get; set; }
        public virtual Collection<RoleTable> RoleTables { get; set; }

        [InverseProperty("CreatedUserGroupTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedUserGroupTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
