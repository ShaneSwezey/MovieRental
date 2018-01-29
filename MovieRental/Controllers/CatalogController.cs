using Microsoft.AspNetCore.Mvc;
using MovieData;
using MovieRental.Models.Catalog;
using System.Linq;

namespace MovieRental.Controllers
{
    public class CatalogController : Controller
    {

        private IMovieResource _movies;

        public CatalogController(IMovieResource movies)
        {
            _movies = movies;
        }


        public IActionResult Index()
        {
            var movieModels = _movies.GetAll();

            var listingResult = movieModels
                 .Select(result => new MovieIndexListingModel
                 {
                     Id = result.MovieId,
                     PosterUrl = result.PosterUrl,
                     Director = result.Director,
                     Title = result.Title,
                     Genre = result.Genre
                 });

            var model = new MovieIndexModel()
            {
                Movies = listingResult
            };

            return View(model);
        }
        
        public IActionResult Detail(int id)
        {
            var movie = _movies.GetById(id);

            var movieDetail = new MovieDetailModel()
            {
                MovieId = movie.MovieId,
                Title = movie.Title,
                Director = movie.Director,
                Genre = movie.Genre,
                ReleaseDate = movie.ReleaseDate,
                Synopsis = movie.Synopsis,
                Rating = movie.Rating,
                UserRating = movie.UserRating,
                ImageUrl = movie.PosterUrl,
                Actors = _movies.GetActors(id).ToList()
            };

            return View(movieDetail);
        }


    }
}
