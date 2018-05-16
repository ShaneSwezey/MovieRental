using Microsoft.EntityFrameworkCore;
using MovieData.Models;
using System;

namespace MovieData
{
    // Entity framework Database context
    public class MovieContext : DbContext
    {

        public MovieContext(DbContextOptions options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Patreon> Patreons { get; set; }
        public DbSet<CarouselMovies> CarouselMovies { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyEmail> CompanyEmail { get; set; }
        public DbSet<CompanyPhoneNumber> CompanyPhoneNumber { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>()
                .HasKey(t => new { t.MovieId, t.ActorId });

            modelBuilder.Entity<MovieActor>()
                .HasOne(pt => pt.Movie)
                .WithMany(p => p.MovieActors)
                .HasForeignKey(pt => pt.MovieId);

            modelBuilder.Entity<MovieActor>()
                .HasOne(pt => pt.Actor)
                .WithMany(t => t.MovieActors)
                .HasForeignKey(pt => pt.ActorId);

            modelBuilder.Entity<Company>()
                .HasMany(c => c.CompanyEmails)
                .WithOne(e => e.Company);

            modelBuilder.Entity<Company>()
                .HasMany(c => c.CompanyPhoneNumbers)
                .WithOne(e => e.Company);

        }
      

    }

}
