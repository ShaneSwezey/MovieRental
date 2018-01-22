using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieData.Models
{
    public class Patreon
    {

        public int PatreonId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string LoginName { get; set; }
        [Required, MinLength(5), MaxLength(50), DataType(DataType.Password), Display(Name = "Password *")]
        public string Password { get; set; }





    }
}
