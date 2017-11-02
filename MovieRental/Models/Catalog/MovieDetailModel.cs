using MovieData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models.Catalog
{
    public class MovieDetailModel
    {

        public int MovieId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }

        [Display(Name = "ReleaseDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public string Synopsis { get; set; }
        public string UserRating { get; set; }
        public string Director { get; set; }

        public List<Actor> Actors { get; set; }

    }
}
