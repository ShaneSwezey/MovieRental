using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieData.Models
{
    // Model for table Patreon in MovieDB
    public class Patreon
    {
        // Primary Key in table Patreon in MovieDB {{int}}
        public int PatreonId { get; set; }
        [Required]
        // First name of patreon {{nvarchar(Max)}}
        public string FirstName { get; set; }
        // Last name of patreon {{nvarchar(Max)}}
        [Required]
        public string LastName { get; set; }
        // Address of patreon {{nvarchar(Max)}}
        [Required]
        public string Address { get; set; }
        // Email address for patreon {{nvarchar(Max)}}
        [EmailAddress]
        public string EmailAddress { get; set; }
        // Phone number of patreon {{nvarchar(Max)}}
        public string PhoneNumber { get; set; }
        // Login name for patreon {{nvarchar(Max)}}
        [Required]
        public string LoginName { get; set; }
        // Password for patreon {{nvarchar(Max)}}
        [Required, MinLength(5), MaxLength(50), DataType(DataType.Password), Display(Name = "Password *")]
        public string Password { get; set; }

    }
}
