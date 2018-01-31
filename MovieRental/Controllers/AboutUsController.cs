using Microsoft.AspNetCore.Mvc;
using MovieData;
using MovieRental.Models.AboutUs;
using System.Linq;

namespace MovieRental.Controllers
{
    public class AboutUsController : Controller
    {

        private ICompanyResource _companyServices;

        public AboutUsController(ICompanyResource companyServices)
        {
            _companyServices = companyServices;
        }

        public IActionResult Index()
        {

            var companyList = _companyServices.GetAll();

            var companyListing = companyList
                .Select(result => new CompanyDetailModel
                {
                    OfficeId = result.OfficeId,
                    Address = result.Address,
                    City = result.City,
                    State = result.State,
                    ImageAddress = result.ImageAddress,

                    CompanyEmails = result.CompanyEmails
                    .Select(c => c.EmailAddress),

                    CompanyPhoneNumbers = result.CompanyPhoneNumbers
                    .Select(c => c.PhoneNumber)
                });

            var officeList = new CompanyListingModel
            {
                OfficeList = companyListing
            };
            

            return View(officeList);
        }

    }
}
