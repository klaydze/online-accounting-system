using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class CashReceiptJournal : Journal
    {
        [Column(TypeName = "varchar(15)")]
        public DateTime CashReceiptNo { get; set; }

        [Column(TypeName = "varchar(100)")]
        public String Payee { get; set; }
    }
}