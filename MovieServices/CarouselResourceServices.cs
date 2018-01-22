using MovieData;
using MovieData.Models;
using System;
using System.Linq;
using System.Collections;

namespace MovieServices
{
    public class CarouselResourceServices : ICarouselResource
    {
        private MovieContext _context;

        public CarouselResourceServices(MovieContext context)
        {
            _context = context ?? throw new ArgumentException();
        }

        public IQueryable<CarouselMovies> GetMovies()
        {
            return _context.CarouselMovies;
        }


        public Hashtable GetMoviesTable()
        {
            Hashtable movieTable = new Hashtable();

            foreach (var movie in _context.CarouselMovies)
            {
                movieTable.Add(movie.MovieId, movie.CroppedPosterURL);
            }

            return movieTable;
        }
    }
}
