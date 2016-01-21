using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Contact
{
    public class ContactTypeTable 
    {
        [Key]
        public int ContactTypeId { get; set; }
        [Index("ContactTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string ContactTypeCode { get; set; }
        public string ContactTypeName { get; set; }
        public string ContactTypeNameInLatin { get; set; }
        
        public virtual Collection<ContactMemberTypeTable> ContactMemberTypeTables { get; set; }

       
    }
}
