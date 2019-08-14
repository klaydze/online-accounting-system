using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class ProfitCentreAccount : IAuditableEntity
    {
        [Key]
        public Guid PCAccountID { get; set; }

        public Guid ProfitCentreID { get; set; }

        public Guid AccountID { get; set; }

        public bool Active { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        public virtual ChartOfAccount ChartOfAccount { get; set; }

        public virtual ProfitCentre ProfitCentre { get; set; }
    }
}
