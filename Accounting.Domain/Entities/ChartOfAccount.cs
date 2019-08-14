using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class ChartOfAccount : IAuditableEntity
    {
        [Key]
        public Guid AccountID { get; set; }

        [Column(TypeName = "varchar(5)")]
        public String Code { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(6)")]
        public String Nature { get; set; }

        public Guid GroupID { get; set; }

        public bool Active { get; set; }

        public Guid AccountTypeID { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("AccountTypeID")]
        public virtual AccountType accountType { get; set; }
    }
}