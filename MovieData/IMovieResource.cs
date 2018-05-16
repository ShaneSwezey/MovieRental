using MovieData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieData
{
    public interface IMovieResource
    {
        // Returns an IEnumerable of all Movie models
        IEnumerable<Movie> GetAll();
        // Returns Movie model with respected parameter id
        Movie GetById(int id);
        // Adds a new movie to table Movies in MovieDB
        void Add(Movie newMovie);
        // Returns full name of the director
        string GetDirector(int id);
        // Returns title of movie
        string GetTitle(int id);
        // Returns genre of moviie
        string GetGenre(int id);
        // Returns the Motion Picture Association of America film rating of the film
        string GetRating(int id);
        // Returns the release date of the movie
        DateTime GetReleaseDate(int id);
        // Returns the synopsis of the film
        string GetSynopsis(int id);
        // Returns user rating of the film
        string GetUserRating(int id);
        // Returns the poster assest location
        string GetPosterUrl(int id);
        
        // ** Needs to be transfered into IActorResource
        IEnumerable<Actor> GetActors(int id);
        Actor GetActorById(int id);

    }
}
