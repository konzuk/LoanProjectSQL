using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class PaymentRemainingTypeTable
    {
        [Key]
        public int PaymentRemainingTypeId { get; set; }
        [Index("PaymentRemainingTypeCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string PaymentRemainingTypeCode { get; set; }
        public string PaymentRemainingTypeName { get; set; }
        public string PaymentRemainingTypeNameInLatin { get; set; }

        public virtual Collection<PaymentItemTable> PaymentItemTables { get; set; } 
    }
}
