using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class UserLevelModel
    {
        public Guid UserLevelID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Limit Code to 50 characters.")]
        public String Name { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Limit Category to 250 characters.")]
        public String Description { get; set; }

        public byte[] RowVersion { get; set; }
    }
}