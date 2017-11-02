using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models.Patreons
{
    public class PatreonRegistrationModel
    {
        [Required, Display(Name = "First Name *")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name *")]
        public string LastName { get; set; }
        [Required, Display(Name = "Address *")]
        public string Address { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required, Display(Name = "Login Name *")]
        public string LoginName { get; set; }
        [Required, MinLength(5), MaxLength(50), DataType(DataType.Password), Display(Name = "Password *")]
        public string Password { get; set; }
        [Required, MinLength(5), MaxLength(50), DataType(DataType.Password), Display(Name = "Confirm Password *")]
        [Compare("Password", ErrorMessage = "The password does not match the confirmation password.")]
        public string ComformationPassword { get; set; }




    }
}
