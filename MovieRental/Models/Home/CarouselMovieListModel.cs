using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.Models.Home
{
    public class CarouselMovieListModel
    {
        public IEnumerable<CarouselMovieModel> carouselMovieList { get; set; }
    }
}
