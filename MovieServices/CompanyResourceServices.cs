using Microsoft.EntityFrameworkCore;
using MovieData;
using MovieData.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieServices
{
    public class CompanyResourceServices : ICompanyResource
    {
        // DbContext
        private MovieContext _context;

        public CompanyResourceServices(MovieContext context)
        {
            _context = context;
        }

        public string GetAddress(int id)
        {
            var address = _context.Company
                .FirstOrDefault(c => c.OfficeId == id)
                .Address;
            return address;
        }

        public IEnumerable<Company> GetAll()
        {
            return _context.Company
                .Include(c => c.CompanyPhoneNumbers)
                .Include(c => c.CompanyEmails);
        }

        public string GetCity(int id)
        {
            var city = _context.Company
                .FirstOrDefault(c => c.OfficeId == id)
                .City;
            return city;
        }

        public IEnumerable<CompanyEmail> GetCompanyEmailAddresses(int id)
        {
            var emailList = _context.CompanyEmail
                .Where(c => c.OfficeRefId == id);

            return emailList;
                
        }

        public IEnumerable<CompanyPhoneNumber> GetCompanyPhoneNumbers(int id)
        {
            var phoneNumbersList = _context.CompanyPhoneNumber
                .Where(c => c.OfficeRefId == id);
            return phoneNumbersList;
        }

        public string GetImageAddress(int id)
        {
            return _context.Company
                .FirstOrDefault(c => c.OfficeId == id)
                .ImageAddress;
        }

        public Company GetOfficeById(int id)
        {
            return _context.Company
                .FirstOrDefault(c => c.OfficeId == id);
                
        }

        public string GetState(int id)
        {
            return _context.Company
                .FirstOrDefault(c => c.OfficeId == id)
                .State;
        }
    }
}
