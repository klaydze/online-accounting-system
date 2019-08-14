using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class AccountTypeModel
    {
        public Guid AccountTypeID { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "Limit Code to 5 characters.")]
        public String Code { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Limit Category to 100 characters.")]
        public String Category { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Limit Description to 50 characters.")]
        public String Description { get; set; }

        public byte[] RowVersion { get; set; }
    }
}