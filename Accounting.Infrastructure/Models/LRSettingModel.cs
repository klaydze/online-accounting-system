using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class LRSettingModel
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
        public String Purpose { get; set; }

        [Required]
        public String Eligibility { get; set; }

        [Required]
        public String Requirements { get; set; }

        public double MinPayment { get; set; }

        [Required]
        public String MinPaymentScheme { get; set; }

        public bool WithCoMaker { get; set; }

        public int RequiredCoMaker { get; set; }

        public bool MemberOnly { get; set; }

        public bool AllowMultiple { get; set; }

        public int ReceivedFromA { get; set; }

        public int ReceivedToA { get; set; }

        public int ReleasedDayA { get; set; }

        public int ReceivedFromB { get; set; }

        public int ReceivedToB { get; set; }

        public int ReleasedDayB { get; set; }

        [Required]
        public Guid PCAccountID { get; set; }

        [Required]
        public Guid IntAccountID { get; set; }

        public Guid PenaltyAccountID { get; set; }

        public Guid LRAccountID { get; set; }

        public Guid LPAccountID { get; set; }

        public Guid LLAccountID { get; set; }

        public Guid UILAccountID { get; set; }

        [Required]
        public DateTime EffectivityDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
