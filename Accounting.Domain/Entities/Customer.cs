using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class Customer : IAuditableEntity
    {
        [Key]
        public Guid CustomerID { get; set; }

        [Column(TypeName = "varchar(8)")]
        public String CustomerNo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime RegDate { get; set; }

        [Column(TypeName = "varchar(30)")]
        public String LastName { get; set; }

        [Column(TypeName = "varchar(30)")]
        public String FirstName { get; set; }

        [Column(TypeName = "varchar(30)")]
        public String MiddleName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String Address1 { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String Address2 { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String Phone { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String Mobile { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime BirthDate { get; set; }

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
