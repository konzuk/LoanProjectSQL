using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Contact
{
    public class GenderTable 
    {
        [Key]
        public int GenderId { get; set; }
        [Index("GenderCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string GenderCode { get; set; }
        public string GenderName { get; set; }
        public string GenderNameInLatin { get; set; }
        
        public virtual Collection<ContactTable> ContactTables { get; set; }

        
    }
}
