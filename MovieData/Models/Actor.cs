using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace MovieData.Models
{
    // Model for Actor table in MovieDb
    public class Actor
    {
        // Primary key in MovieDB.Actors  {{int}}
        [Key]
        public int ActorId { get; set; }
        // First name of Actor in MovieDB.Actors {{nvarchar(Max)}}
        public string FirstName { get; set; }
        // Last name of Actor in MovieDb.Actors {{nvarchar(MAX)}}
        public string LastName { get; set; }

        // Many to Many relationship to MovieDB.MovieActor
        public IEnumerable<MovieActor> MovieActors { get; set; }
    }
}
