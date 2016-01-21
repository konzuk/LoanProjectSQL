using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using MainEntity.Tables.Common;

namespace MainEntity.Tables.Journal
{
    public class PaymentItemTable 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentItemId { get; set; }

        public int LineNumber { get; set; }
        public double PaymentAmountInCompanyCurrency { get; set; }
        public double PaymentAmountInPaymentCurrency { get; set; }
        public double PaymentAmount { get; set; }

        [Index("PaymentItem_Index", 1, IsUnique = true)]
        public int? PaymentJournalId { get; set; }
        [ForeignKey("PaymentJournalId"), InverseProperty("PaymentItemTables")]
        public virtual PaymentTable PaymentTable { get; set; }

        [Index("PaymentItem_Index", 2, IsUnique = true), Required]
        public int JournalId { get; set; }
        [ForeignKey("JournalId"), InverseProperty("PaymetItemTables")]
        public virtual JournalTable JournalTable { get; set; }

        public bool IsRemaining { get { return PaymentRemainingTypeTable!=null; } }
        public int? PaymentRemainingTypeId { get; set; }
        public virtual PaymentRemainingTypeTable PaymentRemainingTypeTable { get; set; }

        public int? ExchangeRateId { get; set; }
        [ForeignKey("ExchangeRateId")]
        public virtual ExchangeRateTable ExchangeRateTable { get; set; }
    }
}
