using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieData;
using MovieData.Models;
using MovieRental.Models.Patreons;

namespace MovieRental.Controllers
{
    public class PatreonController : Controller
    {

        private IPatreonResource _patreons;
        private readonly UserManager<Patreon> _userManager;
        private readonly SignInManager<Patreon> _signInManager;

        public PatreonController(IPatreonResource patreons, UserManager<Patreon> userManager, SignInManager<Patreon> signInManager)
        {
            _patreons = patreons;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        

        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewPatreon()
        {
            return View();
        }

        // Registers new users
        [HttpPost]
        public async System.Threading.Tasks.Task<IActionResult> CreateAccountAsync(PatreonRegistrationModel patreon)
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

    }
}
