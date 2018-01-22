using Microsoft.AspNetCore.Mvc;
using MovieData;
using MovieData.Models;
using MovieRental.Models.Patreons;

namespace MovieRental.Controllers
{
    public class PatreonController : Controller
    {

        private IPatreonResource _patreons;

        public PatreonController(IPatreonResource patreons)
        {
            _patreons = patreons;
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

        [HttpPost]
        public IActionResult CreateAccount(PatreonRegistrationModel patreon)
        {

            if (ModelState.IsValid)
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

                if (!_patreons.IsLoginNameUnique(newUser.LoginName))
                {
                    // Return view with loginIn name not unique
                    // Change in the future
                    return NewPatreon();
                }
                else
                {
                    _patreons.Add(newUser);
                }

            }


            return View();
        }

    }
}
