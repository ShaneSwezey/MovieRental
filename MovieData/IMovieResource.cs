using MovieData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieData
{
    public interface IMovieResource
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int id);

        void Add(Movie newMovie);
        string GetDirector(int id);
        string GetTitle(int id);
        string GetGenre(int id);
        string GetRating(int id);
        DateTime GetReleaseDate(int id);
        string GetSynopsis(int id);
        string GetUserRating(int id);
        string GetPosterUrl(int id);
        List<Actor> GetActors(int id);
        Actor GetActorById(int id);

    }
}
