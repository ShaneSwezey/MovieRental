﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MovieData;
using System;

namespace MovieData.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20180131012441_Company Migration2")]
    partial class CompanyMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieData.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("MovieData.Models.CarouselMovies", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CroppedPosterURL");

                    b.HasKey("MovieId");

                    b.ToTable("CarouselMovies");
                });

            modelBuilder.Entity("MovieData.Models.Company", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("ImageAddress");

                    b.Property<string>("State")
                        .IsRequired();

                    b.HasKey("OfficeId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("MovieData.Models.CompanyEmail", b =>
                {
                    b.Property<int>("CompanyEmailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<int>("OfficeRefId");

                    b.HasKey("CompanyEmailId");

                    b.HasIndex("OfficeRefId");

                    b.ToTable("CompanyEmail");
                });

            modelBuilder.Entity("MovieData.Models.CompanyPhoneNumber", b =>
                {
                    b.Property<int>("CompanyPhoneNumberId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OfficeRefId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("CompanyPhoneNumberId");

                    b.HasIndex("OfficeRefId");

                    b.ToTable("CompanyPhoneNumber");
                });

            modelBuilder.Entity("MovieData.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Director");

                    b.Property<string>("Genre");

                    b.Property<string>("PosterUrl");

                    b.Property<string>("Rating");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Title");

                    b.Property<string>("UserRating");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieData.Models.MovieActor", b =>
                {
                    b.Property<int>("MovieId");

                    b.Property<int>("ActorId");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("MovieData.Models.Patreon", b =>
                {
                    b.Property<int>("PatreonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("LoginName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber");

                    b.HasKey("PatreonId");

                    b.ToTable("Patreons");
                });

            modelBuilder.Entity("MovieData.Models.CompanyEmail", b =>
                {
                    b.HasOne("MovieData.Models.Company", "Company")
                        .WithMany("CompanyEmails")
                        .HasForeignKey("OfficeRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MovieData.Models.CompanyPhoneNumber", b =>
                {
                    b.HasOne("MovieData.Models.Company", "Company")
                        .WithMany("CompanyPhoneNumbers")
                        .HasForeignKey("OfficeRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MovieData.Models.MovieActor", b =>
                {
                    b.HasOne("MovieData.Models.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MovieData.Models.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
