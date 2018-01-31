using Microsoft.AspNetCore.Mvc;
using MovieData;
using MovieRental.Models;
using MovieRental.Models.Home;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections;

namespace MovieRental.Controllers
{
    public class HomeController : Controller
    {

        private IMovieResource _movies;
        private ICarouselResource _carousel;

        public HomeController(IMovieResource movies, ICarouselResource carousel)
        {
            _movies = movies;
            _carousel = carousel;
        }

        // Needs improvement
        public IActionResult Index()
        {
            
            var movieTable = _carousel.GetMoviesTable();
            List<CarouselMovieModel> carouselMovieModelList = new List<CarouselMovieModel>();

            foreach(KeyValuePair<int, string> pair in movieTable)
            {
                int movieKey = pair.Key;
                carouselMovieModelList.Add(new CarouselMovieModel
                {
                    movieId = movieKey,
                    croppedImageUrl = pair.Value,
                    synopsis = _movies.GetSynopsis(movieKey),
                    title = _movies.GetTitle(movieKey)
                });
            }
            
            var listingModel = new CarouselMovieListModel()
            {
                carouselMovieList = carouselMovieModelList
            };

            return View(listingModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
