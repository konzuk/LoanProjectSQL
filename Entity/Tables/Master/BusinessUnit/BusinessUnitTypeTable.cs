using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.BusinessUnit
{
    public class BusinessUnitTypeTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessUnitTypeId { get; set; }
        [Index("BusinessUnitTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string BusinessUnitTypeCode { get; set; }
        public string BusinessUnitTypeName { get; set; }
        public string BusinessUnitTypeNameInLatin { get; set; }
        
        public virtual Collection<BusinessUnitTable> BusinessUnitTables { get; set; }

        [InverseProperty("CreatedBusinessUnitTypeTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedBusinessUnitTypeTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
