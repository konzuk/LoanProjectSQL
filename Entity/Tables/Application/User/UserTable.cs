using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Accounting;
using MainEntity.Tables.Common;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Employee;
using MainEntity.Tables.Item;
using MainEntity.Tables.Journal;
using MainEntity.Tables.Location;

namespace MainEntity.Tables.User
{
    public class UserTable 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Index("UserCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserNameInLatin { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public int? UserGroupId { get; set; }
        [ForeignKey("UserGroupId"), InverseProperty("UserTables")]
        public virtual UserGroupTable UserGroupTable { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId"), InverseProperty("UserTables")]
        public virtual EmployeeTable EmployeeTable { get; set; }

        public virtual Collection<UserSessionTable> UserSessionTables { get; set; } 

        //public virtual Collection<TableBase> CreatedTables { get; set; }
        //public virtual Collection<TableBase> ModefiedTables { get; set; }

        //Common Tables
        public virtual Collection<CurrencyTable> CreatedCurrencyTables { get; set; }
        public virtual Collection<CurrencyTable> ModefiedCurrencyTables { get; set; }
        public virtual Collection<ExchangeRateTable> CreatedExchangeRateTables { get; set; }
        public virtual Collection<ExchangeRateTable> ModefiedExchangeRateTables { get; set; }

        //User Tables
        public virtual Collection<UserGroupTable> CreatedUserGroupTables { get; set; }
        public virtual Collection<UserGroupTable> ModefiedUserGroupTables { get; set; }

        //Contact Tables
        public virtual Collection<ContactTable> CreatedContactTables { get; set; }
        public virtual Collection<ContactTable> ModefiedContactTables { get; set; }
        public virtual Collection<LocationTable> CreatedLocationTables { get; set; }
        public virtual Collection<LocationTable> ModefiedLocationTables { get; set; }
        public virtual Collection<WarehouseTable> CreatedWarehouseTables { get; set; }
        public virtual Collection<WarehouseTable> ModefiedWarehouseTables { get; set; }
        public virtual Collection<NationalityTable> CreatedNationalityTables { get; set; }
        public virtual Collection<NationalityTable> ModefiedNationalityTables { get; set; }
        public virtual Collection<ContactMemberTypeTable> CreatedContactMemberTypeTables { get; set; }
        public virtual Collection<ContactMemberTypeTable> ModefiedContactMemberTypeTables { get; set; }


        //Item Tables   
        public virtual Collection<ItemCategoryTable> CreatedItemCategoryTables { get; set; }
        public virtual Collection<ItemCategoryTable> ModefiedItemCategoryTables { get; set; }
        public virtual Collection<ItemTable> CreatedItemTables { get; set; }
        public virtual Collection<ItemTable> ModefiedItemTables { get; set; }
        public virtual Collection<UnitTable> CreatedUnitTables { get; set; }
        public virtual Collection<UnitTable> ModefiedUnitTables { get; set; }
        public virtual Collection<PriceLevelTable> CreatedPriceLevelTables { get; set; }
        public virtual Collection<PriceLevelTable> ModefiedPriceLevelTables { get; set; }

        //Employee Tables
        public virtual Collection<DepartmentTable> CreatedDepartmentTables { get; set; }
        public virtual Collection<DepartmentTable> ModefiedDepartmentTables { get; set; }
        public virtual Collection<PositionTable> CreatedPositionTables { get; set; }
        public virtual Collection<PositionTable> ModefiedPositionTables { get; set; }


        //Journal Tables
        public virtual Collection<JournalTable> CreatedJournalTables { get; set; }
        public virtual Collection<JournalTable> ModefiedJournalTables { get; set; }

        //Account Tables
        public virtual Collection<AccountTable> CreatedAccountTables { get; set; }
        public virtual Collection<AccountTable> ModefiedAccountTables { get; set; }

    }
}