using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieData.Models
{
    // Model for Movie table in MovieDb
    public class Movie
    {
        // Primary key in table Movie {{int}}
        public int MovieId { get; set; }
        // Title in table Movie {{nvarchar(Max)}}
        public string Title { get; set; }
        // Genre int table Movie {{nvarchar(Max)}}
        public string Genre { get; set; }
        // Director in table Movie {{nvarchar(Max)}}
        public string Director { get; set; }
        // Movie synopsis in table Movie {{nvarchar(Max)}}
        public string Synopsis { get; set; }
        // Motion Picture Association of America film rating of movie in table Movie {{nvarchar(Max)}}
        public string Rating { get; set; }
        // Public user rating of movie in table Movie {{nvarchar(Max)}}
        public string UserRating { get; set; }
        // Release date of movie {{datetime2}}
        public DateTime ReleaseDate { get; set; }
        // Image assest location string for Movie {{nvarchar(Max)}}
        public string PosterUrl { get; set; }

        // MovieActor reference for entity framework
        public List<MovieActor> MovieActors { get; set; }


    }
}
