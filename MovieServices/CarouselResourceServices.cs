using MovieData;
using MovieData.Models;
using System;
using System.Linq;
using System.Collections.Generic;

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


        public Dictionary<int, string> GetMoviesTable()
        {

            Dictionary<int, string> movieTable = new Dictionary<int, string>();

            foreach (var movie in _context.CarouselMovies)
            {
                movieTable.Add(movie.MovieId, movie.CroppedPosterURL);
            }

            return movieTable;
        }
    }
}
