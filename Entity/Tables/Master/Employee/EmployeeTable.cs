using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.BusinessUnit;
using MainEntity.Tables.Contact;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Employee
{
    public class EmployeeTable : ContactTable
    {
        public int? PositionId { get; set; }
        public virtual PositionTable PositionTable { get; set; }
        public int? DepartmentId { get; set; }
        public virtual DepartmentTable DepartmentTable { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string PhotoPath { get; set; }

        public virtual Collection<UserTable> UserTables { get; set; } 

        public DateTime? RegisterDate { get; set; }
        public bool IsResigned { get; set; }
        public DateTime? ResignedDate { get; set; }
        public string Reason { get; set; }



    }
}
