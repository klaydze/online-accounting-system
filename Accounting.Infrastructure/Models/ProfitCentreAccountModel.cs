using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class ProfitCentreAccountModel
    {
        [Required]
        public Guid PCAccountID { get; set; }

        [Required]
        public Guid ProfitCentreID { get; set; }

        [Required]
        public Guid AccountID { get; set; }

        public bool Active { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}