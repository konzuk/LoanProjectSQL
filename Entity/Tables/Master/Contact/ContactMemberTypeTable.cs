using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Contact
{
    public class ContactMemberTypeTable : TableBase
    {
        [Key]
        public int ContactMemberTypeId { get; set; }
        [Index("ContactMemberTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string ContactMemberTypeCode { get; set; }
        public string ContactMemberTypeName { get; set; }
        public string ContactMemberTypeNameInLatin { get; set; }

        public int ContactTypeId { get; set; }
        public virtual ContactTypeTable ContactTypeTable { get; set; }

        public virtual Collection<ContactTable> ContactTables { get; set; }

        [InverseProperty("CreatedContactMemberTypeTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedContactMemberTypeTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
