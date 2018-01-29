using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieData.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<MovieActor> MovieActors { get; set; }
    }
}
