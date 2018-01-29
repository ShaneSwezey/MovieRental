using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieData;
using MovieData.Models;
using MovieRental.Models.Patreons;
using System.Threading.Tasks;

namespace MovieRental.Controllers
{
    public class PatreonController : Controller
    {

        private IPatreonResource _patreons;                         // Pateron Services

        // Pateron Controller Constructor
        public PatreonController(IPatreonResource patreons)
        {
            _patreons = patreons;
           
        }
        
        // Returns login razor view page
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewPatreon()
        {
            return View();
        }
        /*
        // Registers new users
        [HttpPost]
        public async Task<IActionResult> CreateAccountAsync(PatreonRegistrationModel patreon)
        {

            if (!ModelState.IsValid)
            {

                var newUser = new Patreon
                {
                    FirstName = patreon.FirstName,
                    LastName = patreon.LastName,
                    Address = patreon.Address,
                    EmailAddress = patreon.EmailAddress,
                    PhoneNumber = patreon.PhoneNumber,
                    LoginName = patreon.LoginName,
                    Password = patreon.Password
                };

                var result = await _userManager.CreateAsync(newUser, newUser.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(newUser, false);
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(patreon);
        }
        */
    }
}
