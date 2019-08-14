using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class CustomerModel
    {
        public Guid CustomerID { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Limit Customer No to 8 characters.")]
        public String CustomerNo { get; set; }

        [Required]
        public DateTime RegDate { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Limit LastName to 30 characters.")]
        public String LastName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Limit FirstName to 30 characters.")]
        public String FirstName { get; set; }

        [StringLength(30, ErrorMessage = "Limit MiddleName to 30 characters.")]
        public String MiddleName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Limit Address1 to 50 characters.")]
        public String Address1 { get; set; }

        [StringLength(50, ErrorMessage = "Limit Address2 to 50 characters.")]
        public String Address2 { get; set; }

        [StringLength(15, ErrorMessage = "Limit Phone to 15 characters.")]
        public String Phone { get; set; }

        [StringLength(15, ErrorMessage = "Limit Mobile to 15 characters.")]
        public String Mobile { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}