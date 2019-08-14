using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class ReceivableTransactionDetail : IAuditableEntity
    {
        [Key]
        public Guid ReceivableID { get; set; }

        public Guid ReceivableTransactionID { get; set; }

        public Guid JournalDetailID { get; set; }

        public Guid PaymentScheduleID { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
