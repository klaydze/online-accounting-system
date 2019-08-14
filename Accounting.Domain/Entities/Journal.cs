using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class Journal : IAuditableEntity
    {
        public Guid JournalID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public String Particular { get; set; }

        [Column(TypeName = "float")]
        public double Amount { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String Status { get; set; }

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