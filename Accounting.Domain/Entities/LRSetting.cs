using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class LRSetting : ReceivableSetting
    {
        [Column(TypeName = "varchar(max)")]
        public String Purpose { get; set; }

        [Column(TypeName = "varchar(max)")]
        public String Eligibility { get; set; }

        [Column(TypeName = "varchar(max)")]
        public String Requirements { get; set; }

        public double MinPayment { get; set; }

        [Column(TypeName = "varchar(5)")]
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

        public Guid LRAccountID { get; set; }

        public Guid LPAccountID { get; set; }

        public Guid LLAccountID { get; set; }

        public Guid UILAccountID { get; set; }
    }
}
