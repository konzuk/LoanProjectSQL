using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Contact
{
    public class NationalityTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NationalityId { get; set; }
        [Index("NationalityCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string NationalityCode { get; set; }
        public string NationalityName { get; set; }
        public string NationalityNameInLatin { get; set; }
        
        public virtual Collection<ContactTable> ContactTables { get; set; }

        [InverseProperty("CreatedNationalityTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedNationalityTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
