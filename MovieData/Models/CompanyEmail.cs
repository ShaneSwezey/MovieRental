using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieData.Models
{
    public class CompanyEmail
    {
        [Key]
        public int CompanyEmailId { get; set; }
        [Required, EmailAddress]
        public string EmailAddress { get; set; }

        [ForeignKey("Company")]
        public int OfficeRefId { get; set; }
        public Company Company { get; set; }
    }
}
