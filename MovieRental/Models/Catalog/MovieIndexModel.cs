using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.Models.Catalog
{
    public class MovieIndexModel
    {

        public IEnumerable<MovieIndexListingModel> Movies { get; set; }
    }
}
