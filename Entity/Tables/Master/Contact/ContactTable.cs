using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Item;
using MainEntity.Tables.Journal;
using MainEntity.Tables.Location;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Contact
{
    public class ContactTable : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        [Index("ContactCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string ContactCode { get; set; }
        public string ContactName { get; set; }
        public string ContactNameInLatin { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string PhotoPath { get; set; }


        public int ContactMemberTypeId { get; set; }
        public virtual ContactMemberTypeTable ContactMemberTypeTable { get; set; }

        public int? GenderId { get; set; }
        public virtual GenderTable GenderTable { get; set; }

        public int? NationalityId { get; set; }
        public virtual NationalityTable NationalityTable { get; set; }

        public string ContactAddress { get; set; }
        public string ContactAddressInLatin { get; set; }

        public int? LocationId { get; set; }
        public virtual LocationTable LocationTable { get; set; }
        
        public virtual Collection<JournalTable> JournalTables { get; set; }
        public virtual Collection<JournalItemTable> JournalItemTables { get; set; }

        public int? PriceLevelId { get; set; }
        [ForeignKey("PriceLevelId")]
        public virtual PriceLevelTable PriceLevelTable { get; set; }


        [InverseProperty("CreatedContactTables")]
        public override UserTable CreatedBy { get; set; }
        [InverseProperty("ModefiedContactTables")]
        public override UserTable ModefiedBy { get; set; }
    }
}
