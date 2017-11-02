using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieData.Models
{
    public class Movie
    {

        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Synopsis { get; set; }
        public string Rating { get; set; }
        public string UserRating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterUrl { get; set; }


        public List<MovieActor> MovieActors { get; set; }


    }
}
