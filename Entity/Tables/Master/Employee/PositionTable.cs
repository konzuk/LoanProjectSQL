using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Employee
{
    public class PositionTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionId { get; set; }
        [Index("PositionCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string PositionCode { get; set; }
        public string PositionName { get; set; }
        public string PositionNameInLatin { get; set; }

        public virtual Collection<EmployeeTable> EmployeeTables { get; set; }

        [InverseProperty("CreatedPositionTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedPositionTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
