using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class Company : IAuditableEntity
    {
        [Key]
        public Guid CompanyID { get; set; }

        [Column(TypeName = "varchar(200)")]
        public String CompanyName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String Address1 { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String Address2 { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String Phone { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String Mobile { get; set; }

        [Column(TypeName = "varchar(20)")]
        public String TIN { get; set; }

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
