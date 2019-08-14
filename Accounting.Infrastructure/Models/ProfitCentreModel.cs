using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Infrastructure.Models
{
    public class ProfitCentreModel
    {
        public Guid ProfitCentreID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(200, ErrorMessage = "Limit Profit Centre Name to 200 characters.")]
        public String ProfitCentreName { get; set; }

        [Display(Name = "Contact No.")]
        [StringLength(15, ErrorMessage = "Limit Contact No to 15 characters.")]
        public String ContactNo { get; set; }

        [Display(Name = "Mobile No.")]
        [StringLength(15, ErrorMessage = "Limit Mobile No to 15 characters.")]
        public String Mobile { get; set; }

        [Required]
        [Display(Name = "Address 1")]
        [StringLength(50, ErrorMessage = "Limit Address1 to 50 characters.")]
        public String Address1 { get; set; }

        [Display(Name = "Address 2")]
        [StringLength(50, ErrorMessage = "Limit Address2 to 50 characters.")]
        public String Address2 { get; set; }

        [Display(Name = "Address 3")]
        [StringLength(50, ErrorMessage = "Limit Address3 to 50 characters.")]
        public String Address3 { get; set; }

        [Required]
        [Display(Name = "Trade Name")]
        [StringLength(100, ErrorMessage = "Limit Address3 to 100 characters.")]
        public String TradeName { get; set; }

        [Required]
        [Display(Name = "Type")]
        [StringLength(20, ErrorMessage = "Limit Profit Centre Type to 20 characters.")]
        public String ProfitCentreType { get; set; }

        [Required]
        public Guid? CompanyID { get; set; }

        public bool Active { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        public CompanyModel Company { get; set; }
    }
}