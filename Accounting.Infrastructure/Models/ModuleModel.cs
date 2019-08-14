using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class ModuleModel
    {
        public Guid ModuleID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Limit Code to 100 characters.")]
        public String ModuleName { get; set; }

        public byte[] RowVersion { get; set; }
    }
}