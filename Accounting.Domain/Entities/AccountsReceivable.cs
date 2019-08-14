using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class AccountsReceivable : Receivable
    {
        public Guid CustomerID { get; set; }
    }
}
