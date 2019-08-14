using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class CashReceiptJournalModel
    {
        public Guid JournalID { get; set; }

        public DateTime TransactionDate { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Limit Payee to 100 characters.")]
        public String Payee { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Limit Receipt No. to 15 characters.")]
        public DateTime CashReceiptNo { get; set; }

        [Required]
        public String Particular { get; set; }

        [Required]
        public double Amount { get; set; }

        public String Status { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}