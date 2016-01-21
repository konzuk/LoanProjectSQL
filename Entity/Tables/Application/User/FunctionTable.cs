using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class FunctionTable 
    {
        [Key]
        //[ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FunctionId { get; set; }
        [Index("FunctionCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public string FunctionNameInLatin { get; set; }

        public virtual Collection<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }

        
    }
}
