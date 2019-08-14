using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class LoansReceivableModel
    {
        public Guid ReceivableID { get; set; }

        public Guid RSettingID { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime MaturityDate { get; set; }

        [Required]
        public int Term { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public double Amortization { get; set; }

        [Required]
        public double Balance { get; set; }

        [Required]
        public String Status { get; set; }

        public String Remarks { get; set; }

        [Required]
        public Guid MemberID { get; set; }

        public Guid LoanApplicationID { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
