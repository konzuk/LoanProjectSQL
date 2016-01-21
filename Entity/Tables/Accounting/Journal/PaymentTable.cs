using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MainEntity.Tables.Journal
{
    public class PaymentTable : JournalTable
    {
        public double PaymentAmount { get; set; }
        public double PaymentAmountInCompanyCurrency { get; set; }
        public bool IsFIFO { get; set; }

        public bool IsSettlement { get; set; } //កាត់កងវិក្ក័យប័ត្រ
        public int? SettlementJournalId { get; set; }
        [ForeignKey("SettlementJournalId"), InverseProperty("PaymentSettlementTables")]
        public virtual JournalTable SettlementJournalTable { get; set; }

        public virtual Collection<PaymentItemTable> PaymentItemTables { get; set; } 

    }
}
