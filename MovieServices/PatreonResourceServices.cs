using MovieData;
using MovieData.Models;
using System;
using System.Linq;


namespace MovieServices
{
    public class PatreonResourceServices : IPatreonResource
    {

        private MovieContext _context;

        public PatreonResourceServices(MovieContext context)
        {
            _context = context;
        }

        public void Add(Patreon newUser)
        {
            _context.Add(newUser);
            _context.SaveChanges();
        }

        public Patreon GetById(int id)
        {
            return _context.Patreons.FirstOrDefault(patreon => patreon.PatreonId == id);
        }

        public string GetAddress(int id)
        {
            var patreon = GetById(id);
            if (patreon == null)
            {
                return "";
            }
            return patreon.Address;
        }

        public string GetEmailAddress(int id)
        {
            var patreon = GetById(id);
            if (patreon == null)
            {
                return "";
            }
            return patreon.EmailAddress;
        }

        public string GetFirstName(int id)
        {
            var patreon = GetById(id);
            if (patreon == null)
            {
                return "";
            }
            return patreon.FirstName;
        }

        public string GetLastName(int id)
        {
            var patreon = GetById(id);
            if (patreon == null)
            {
                return "";
            }
            return patreon.LastName;
        }

        public Patreon GetPatreon(string loginName, string userPassword)
        {
            return _context.Patreons.FirstOrDefault(patreon => patreon.LoginName.Equals(loginName) && patreon.Password.Equals(userPassword));
        }

        public string GetPhoneNumber(int id)
        {
            var patreon = GetById(id);
            if (patreon == null)
            {
                return "";
            }
            return patreon.PhoneNumber;
        }

        public bool IsLoginNameUnique(string proposedLoginName)
        {
            return _context.Patreons.All(patreon => patreon.LoginName.Equals(proposedLoginName, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
