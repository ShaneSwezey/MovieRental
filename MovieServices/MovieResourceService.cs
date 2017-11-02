using MovieData;
using MovieData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MovieServices
{
    public class MovieResourceService : IMovieResource
    {

        private MovieContext _context;

        public MovieResourceService(MovieContext context)
        {
            _context = context;
        }


        public void Add(Movie newMovie)
        {
            _context.Add(newMovie);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies;
        }

        public Movie GetById(int id)
        {
            return _context.Movies
                .Include(movie => movie.MovieActors)
                .FirstOrDefault(movie => movie.MovieId == id);
           
        }

        public string GetDirector(int id)
        {
            var movie = GetById(id);
            if (movie.Equals(null))
            {
                return "";
            }
            return movie.Director;
        }

        public string GetGenre(int id)
        {
            var movie = GetById(id);
            if (movie.Equals(null))
            {
                return "";
            }
            return movie.Genre;
        }

        public string GetRating(int id)
        {
            var movie = GetById(id);
            if (movie.Equals(null))
            {
                return "";
            }
            return movie.Rating;
        }

        public DateTime GetReleaseDate(int id)
        {
            var movie = GetById(id);
            if (movie.Equals(null))
            {
                return DateTime.Today;
            }
            return movie.ReleaseDate;
        }

        public string GetSynopsis(int id)
        {
            var movie = GetById(id);
            if (movie.Equals(null))
            {
                return "";
            }
            return movie.Synopsis;
        }

        public string GetTitle(int id)
        {
            var movie = GetById(id);
            if (movie.Equals(null))
            {
                return "";
            }
            return movie.Title;
        }

        public string GetUserRating(int id)
        {
            var movie = GetById(id);
            if (movie.Equals(null))
            {
                return "";
            }
            return movie.UserRating;
        }

        public string GetPosterUrl(int id)
        {
            var movie = GetById(id);
            if (movie.Equals(null))
            {
                return "";
            }
            return movie.PosterUrl;
        }

        
        public List<Actor> GetActors(int id)
        {
            var movie = GetById(id);
            if (movie.Equals(null) || movie.MovieActors.Equals(null))
            {
                return null;
            }
      
            List<Actor> actors = new List<Actor>();

            foreach(MovieActor a in movie.MovieActors)
            {
                Actor actor = GetActorById(a.ActorId);
                actors.Add(actor);
            }

            return actors;
        }

        public Actor GetActorById(int id)
        {
            return _context.Actors.FirstOrDefault(actor => actor.ActorId == id);
        }


    }
}
