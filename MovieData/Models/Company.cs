using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieData.Models
{
    public class Company
    {
        [Key]
        public int OfficeId { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Address { get; set; }
        public string ImageAddress { get; set; }

        public ICollection<CompanyEmail> CompanyEmails { get; set; }
        public ICollection<CompanyPhoneNumber> CompanyPhoneNumbers { get; set; }

    }
}
