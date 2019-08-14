using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class JournalDetailModel
    {
        public Guid JournalDetailID { get; set; }

        public Guid JournalID { get; set; }

        public Guid PCAccountID { get; set; }

        public double Amount { get; set; }

        public String Nature { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}