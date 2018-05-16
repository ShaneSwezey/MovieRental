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
            return _context.Movies
                .FirstOrDefault(m => m.MovieId == id)
                .Director;
        }

        public string GetGenre(int id)
        {
            return _context.Movies
                .FirstOrDefault(m => m.MovieId == id)
                .Genre;
        }

        public string GetRating(int id)
        {
            return _context.Movies
                .FirstOrDefault(m => m.MovieId == id)
                .Rating;
        }

        public DateTime GetReleaseDate(int id)
        {
            return _context.Movies
                .FirstOrDefault(m => m.MovieId == id)
                .ReleaseDate;
        }

        public string GetSynopsis(int id)
        {
            return _context.Movies
                .FirstOrDefault(m => m.MovieId == id)
                .Synopsis;
        }

        public string GetTitle(int id)
        {
            return _context.Movies
                .FirstOrDefault(m => m.MovieId == id)
                .Title;
        }

        public string GetUserRating(int id)
        {
            return _context.Movies
                .FirstOrDefault(m => m.MovieId == id)
                .UserRating;
        }

        public string GetPosterUrl(int id)
        {
            return _context.Movies
                .FirstOrDefault(m => m.MovieId == id)
                .PosterUrl;
        }

        
        public IEnumerable<Actor> GetActors(int id)
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
