using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Item
{
    public class PriceLevelTypeTable
    {
        [Key]
        public int PriceLevelTypeId { get; set; }
        [Index("PriceLevelTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string PriceLevelTypeCode { get; set; }
        public string PriceLevelTypeName { get; set; }
        public string PriceLevelTypeNameInLatin { get; set; }
   
        public virtual Collection<PriceLevelTable> PriceLevelTables { get; set; }

        
    }
}
