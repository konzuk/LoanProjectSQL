using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class ApplicationTable 
    {
        [Key]
        //[ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }

        [Index("ApplicationCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationNameInLatin { get; set; }
       
        public virtual Collection<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }

       
    }
}
