using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class AccountType : IAuditableEntity
    {
        [Key]
        public Guid AccountTypeID { get; set; }

        [Column(TypeName = "varchar(5)")]
        public String Code { get; set; }

        [Column(TypeName = "varchar(100)")]
        public String Category { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String Description { get; set; }

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