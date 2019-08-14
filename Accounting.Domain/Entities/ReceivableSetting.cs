using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class ReceivableSetting : IAuditableEntity
    {
        [Key]
        public Guid RSettingID { get; set; }

        [Column(TypeName = "varchar(5)")]
        public String Code { get; set; }

        [Column(TypeName = "varchar(100)")]
        public String Description { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String PaymentMode { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String PenaltyMode { get; set; }

        [Column(TypeName = "varchar(15)")]
        public String InterestMode { get; set; }

        public double InterestRate { get; set; }

        public double PenaltyRate { get; set; }

        public int Term { get; set; }

        public int IntOutright { get; set; }

        public bool WithRebates { get; set; }

        public Guid PCAccountID { get; set; }

        public Guid IntAccountID { get; set; }

        public Guid PenaltyAccountID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime EffectivityDate { get; set; }

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