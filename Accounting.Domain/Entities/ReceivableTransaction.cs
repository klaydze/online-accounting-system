using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class ReceivableTransaction : IAuditableEntity
    {
        public Guid ReceivableTransactionID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime TransationDate { get; set; }

        public Guid ReceivableID { get; set; }

        public double Amount { get; set; }

        public Guid JournalID { get; set; }

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
