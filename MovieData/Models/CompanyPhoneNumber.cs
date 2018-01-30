using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieData.Models
{
    public class CompanyPhoneNumber
    {
        [Key]
        public int CompanyPhoneNumberId { get; set; }
        [Required, Phone, Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        [ForeignKey("Company")]
        public int OfficeRefId { get; set; }
        public Company Company { get; set; }
    }
}
