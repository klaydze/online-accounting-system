using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class ProfitCentre : IAuditableEntity
    {
        [Key]
        public Guid ProfitCentreID { get; set; }

        [Column(TypeName = "varchar(200)")]
        public String ProfitCentreName { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String ContactNo { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String Mobile { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String Address1 { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String Address2 { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String Address3 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public String TradeName { get; set; }

        [Column(TypeName = "varchar(20)")]
        public String ProfitCentreType { get; set; }

        public Guid? CompanyID { get; set; }

        public bool Active { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }
    }
}
