using System;
using System.Collections.Generic;
using System.Text;

namespace MovieData.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<MovieActor> MovieActors { get; set; }
    }
}
