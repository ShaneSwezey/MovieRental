using System.ComponentModel.DataAnnotations;

namespace MovieData.Models
{
    public class CarouselMovies
    {
        [Key]
        public int MovieId { get; set; }
        public string CroppedPosterURL { get; set; }
    }
}
