using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class Receivable : IAuditableEntity
    {
        public Guid ReceivableID { get; set; }

        public Guid RSettingID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ReleaseDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime MaturityDate { get; set; }

        public int Term { get; set; }

        public double Amount { get; set; }

        public double Amortization { get; set; }

        public double Balance { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String Status { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public String Remarks { get; set; }

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
