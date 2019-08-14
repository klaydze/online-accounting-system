using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class ARSettingModel
    {
        [Key]
        public Guid RSettingID { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "Limit Code to 5 characters.")]
        public String Code { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Limit Description to 100 characters.")]
        public String Description { get; set; }

        [Required]
        public String PaymentMode { get; set; }

        [Required]
        public String PenaltyMode { get; set; }

        [Required]
        public String InterestMode { get; set; }

        [Required]
        public double InterestRate { get; set; }

        public double PenaltyRate { get; set; }

        public double Term { get; set; }

        public double IntOutright { get; set; }

        public bool WithRebates { get; set; }

        [Required]
        public Guid SalesAccountID { get; set; }

        [Required]
        public Guid PCAccountID { get; set; }

        [Required]
        public Guid IntAccountID { get; set; }

        public Guid PenaltyAccountID { get; set; }

        [Required]
        public DateTime EffectivityDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
