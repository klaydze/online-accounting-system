using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class CompanyModel
    {
        public Guid CompanyID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(200, ErrorMessage = "Limit CompanyName to 200 characters.")]
        public String CompanyName { get; set; }

        [Required]
        [Display(Name = "Address 1")]
        [StringLength(50, ErrorMessage = "Limit Address1 to 50 characters.")]
        public String Address1 { get; set; }

        [Display(Name = "Address 2")]
        [StringLength(50, ErrorMessage = "Limit Address2 to 50 characters.")]
        public String Address2 { get; set; }

        [StringLength(15, ErrorMessage = "Limit Phone to 15 characters.")]
        public String Phone { get; set; }

        [StringLength(15, ErrorMessage = "Limit Mobile to 15 characters.")]
        public String Mobile { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Limit TIN to 20 characters.")]
        public String TIN { get; set; }

        public byte[] RowVersion { get; set; }
    }
}