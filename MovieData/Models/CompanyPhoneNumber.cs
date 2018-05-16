using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieData.Models
{
    // Model for Compnay phone numbers in MovieDb
    public class CompanyPhoneNumber
    {
        // Primary key in table companyphonenumber in MovieDb {{int}}
        [Key]
        public int CompanyPhoneNumberId { get; set; }
        // Phone number {{nvarchar(Max)}}
        [Required, Phone, Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        // ForeignKey for Company table 
        [ForeignKey("Company")]
        public int OfficeRefId { get; set; }
        public Company Company { get; set; }
    }
}
