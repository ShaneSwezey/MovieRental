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
            return _context.Patreons
                .FirstOrDefault(p => p.PatreonId == id)
                .Address;
        }

        public string GetEmailAddress(int id)
        {
            return _context.Patreons
                .FirstOrDefault(p => p.PatreonId == id)
                .EmailAddress;
        }

        public string GetFirstName(int id)
        {
            return _context.Patreons
                .FirstOrDefault(p => p.PatreonId == id)
                .FirstName;
        }

        public string GetLastName(int id)
        {
            return _context.Patreons
                .FirstOrDefault(p => p.PatreonId == id)
                .LastName;
        }

        public Patreon GetPatreon(string loginName, string userPassword)
        {
            return _context.Patreons.FirstOrDefault(patreon => patreon.LoginName.Equals(loginName) && patreon.Password.Equals(userPassword));
        }

        public string GetPhoneNumber(int id)
        {
            return _context.Patreons
                 .FirstOrDefault(p => p.PatreonId == id)
                 .PhoneNumber;
        }

        public bool IsLoginNameUnique(string proposedLoginName)
        {
            return _context.Patreons.All(patreon => patreon.LoginName.Equals(proposedLoginName, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
