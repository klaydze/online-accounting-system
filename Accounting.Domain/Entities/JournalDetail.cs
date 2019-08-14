using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class JournalDetail : IAuditableEntity
    {
        public Guid JournalDetailID { get; set; }

        public Guid JournalID { get; set; }

        public Guid PCAccountID { get; set; }

        [Column(TypeName = "float")]
        public double Amount { get; set; }

        [Column(TypeName = "varchar(6)")]
        public String Nature { get; set; }

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