using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class PaymentSchedule : IAuditableEntity
    {
        public Guid PaymentScheduleID { get; set; }

        public Guid ReceivableID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String Type { get; set; }

        public double Amount { get; set; }

        public Guid PCAccountID { get; set; }

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
