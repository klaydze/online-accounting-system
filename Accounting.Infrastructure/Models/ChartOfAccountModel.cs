using Accounting.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class ChartOfAccountModel
    {
        public Guid AccountID { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "Limit Code to 5 characters.")]
        public String Code { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Limit Title to 100 characters.")]
        public String Title { get; set; }

        [StringLength(50, ErrorMessage = "Limit Description to 50 characters.")]
        public String Description { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "Limit Nature to 2 characters.")]
        public String Nature { get; set; }

        [Display(Name = "Group")]
        public Guid GroupID { get; set; }

        [Required]
        [Display(Name = "Account Type")]
        public Guid AccountTypeID { get; set; }

        [Required]
        public String Active { get; set; }

        public byte[] RowVersion { get; set; }

        public AccountType accountType { get; set; }
    }
}