using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class PaymentScheduleModel
    {
        public Guid PaymentScheduleID { get; set; }

        public Guid ReceivableID { get; set; }

        public DateTime PaymentDate { get; set; }

        public String Type { get; set; }

        public double Amount { get; set; }

        public Guid PCAccountID { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
