﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieData.Models
{
    // Model for Many to many table MovieActor
    // Conntects table movie to table Actor
    public class MovieActor
    {
        // MovieId reference key in table Movie
        public int MovieId { get; set;}
        // Entity reference
        public Movie Movie { get; set; }
        // ActorId reference key in table Actor
        public int ActorId { get; set; }
        // Entity reference
        public Actor Actor { get; set; }

    }
}
