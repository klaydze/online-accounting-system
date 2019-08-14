using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class ReceivableTransactionModel
    {
        public Guid ReceivableTransactionID { get; set; }

        [Required]
        public DateTime TransationDate { get; set; }

        [Required]
        public Guid ReceivableID { get; set; }

        [Required]
        public double Amount { get; set; }

        public Guid JournalID { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
