using System.ComponentModel.DataAnnotations;

namespace MovieData.Models
{
    // Model for movie images for the home/index page carousel
    public class CarouselMovies
    {
        // Primary key for MovieDB.CarouselMovies {{int}}
        [Key]
        public int MovieId { get; set; }
        // Image file location string for Home/Index carousel {{varchar(Max)}}
        public string CroppedPosterURL { get; set; }
    }
}
