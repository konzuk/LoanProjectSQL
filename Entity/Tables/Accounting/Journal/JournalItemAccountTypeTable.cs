using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class JournalItemAccountTypeTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JournalItemAccountTypeId { get; set; }

        [Index("JournalItemAccountType_Index", 1, IsUnique = true), Required]
        public int JournalId { get; set; }
        public JournalTable JournalTable { get; set; }

        [Index("JournalItemAccountType_Index", 2, IsUnique = true), Required]
        public int JournalItemAccountId { get; set; }
        public JournalItemAccountTable JournalItemAccountTable { get; set; }

        [Index("JournalItemAccountType_Index", 3, IsUnique = true), Required]
        public int JournalTypeId { get; set; }
        public JournalTypeTable JournalTypeTable { get; set; }

        [DefaultValue(true)]
        public bool IsMain { get; set; }
    }
}
