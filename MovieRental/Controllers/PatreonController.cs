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
                var user = new Patreon
                {
                    FirstName = patreon.FirstName,
                    LastName = patreon.LastName,
                    Address = patreon.Address,
                    EmailAddress = patreon.EmailAddress,
                    PhoneNumber = patreon.PhoneNumber,
                    LoginName = patreon.LoginName,
                    Password = patreon.Password
                };

                //var result = await _patreons.

            }


            return View();
        }

    }
}
