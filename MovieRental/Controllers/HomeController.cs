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
            //List<CarouselMovies> carouselMovies = _carousel.GetMovies().ToList();
            Hashtable movieTable = _carousel.GetMoviesTable();
            List<CarouselMovieModel> carouselMovieModelList = new List<CarouselMovieModel>();

            foreach(DictionaryEntry pair in movieTable)
            {
                int movieKey = (int)pair.Key;
                carouselMovieModelList.Add(new CarouselMovieModel
                {
                    movieId = movieKey,
                    croppedImageUrl = (string) pair.Value,
                    synopsis = _movies.GetSynopsis(movieKey),
                    title = _movies.GetTitle(movieKey)
                });
            }


            /*
            for (int i = 0; i < carouselMovies.Count; i++)
            {
                int movieId = carouselMovies[i].MovieId;
                carouselMovieModelList.Add(new CarouselMovieModel
                {
                    movieId = movieId,
                    title = _movies.GetTitle(movieId),
                    croppedImageUrl = carouselMovies[i].CroppedPosterURL,
                    synopsis = _movies.GetSynopsis(movieId)
                });
            }
            */
            
            var listingModel = new CarouselMovieListModel()
            {
                carouselMovieList = carouselMovieModelList
            };

            return View(listingModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
