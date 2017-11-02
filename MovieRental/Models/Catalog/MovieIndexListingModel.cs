using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.Models.Catalog
{
    public class MovieIndexListingModel
    {

        public int Id { get; set; }
        public string PosterUrl { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        

    }
}
