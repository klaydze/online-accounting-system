using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class ReceivableTransactionDetailModel
    {
        public Guid ReceivableID { get; set; }

        public Guid ReceivableTransactionID { get; set; }

        public Guid JournalDetailID { get; set; }

        public Guid PaymentScheduleID { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
