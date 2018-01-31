using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.Models.AboutUs
{
    public class CompanyDetailModel
    {
        public int OfficeId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string ImageAddress { get; set; }

        public IEnumerable<string> CompanyEmails { get; set; }
        public IEnumerable<string> CompanyPhoneNumbers { get; set; }
    }
}
