using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class LoansReceivable : Receivable
    {
        public Guid MemberID { get; set; }

        public Guid LoanApplicationID { get; set; }
    }
}
