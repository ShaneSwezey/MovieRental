using MovieData.Models;
using System.Linq;
using System.Collections.Generic;

namespace MovieData
{
    public interface ICarouselResource
    {
        // Retreives movie ids for home page carousel.
        IQueryable<CarouselMovies> GetMovies();
        Dictionary<int, string> GetMoviesTable();
    }
}
