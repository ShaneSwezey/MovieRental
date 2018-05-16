using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieData.Models
{
    // Model for Company table in MovieDb
    public class Company
    {
        // Primary key for MovieDb.Company {{int}}
        [Key]
        public int OfficeId { get; set; }
        // Office city location  {{varchar(Max)}}
        [Required]
        public string City { get; set; }
        // Office state location {{varchar(Max)}}
        [Required]
        public string State { get; set; }
        // Office address {{varchar(Max)}}
        [Required]
        public string Address { get; set; }
        // Office image assest location string {{varchar(Max)}}
        public string ImageAddress { get; set; }

        public ICollection<CompanyEmail> CompanyEmails { get; set; }
        public ICollection<CompanyPhoneNumber> CompanyPhoneNumbers { get; set; }

    }
}
