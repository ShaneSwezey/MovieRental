using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieData.Models
{
    // Model for CompanyEmails from MovieDB
    public class CompanyEmail
    {
        // Primary key for companyemail table from MovieDB {{int}}}
        [Key]
        public int CompanyEmailId { get; set; }
        // Email address for office {{varchar(Max)}} 
        [Required, EmailAddress]
        public string EmailAddress { get; set; }
        // foreignKey for Company table {{int}}
        [ForeignKey("Company")]
        public int OfficeRefId { get; set; }
        // Company reference for Enity framework
        public Company Company { get; set; }
    }
}
