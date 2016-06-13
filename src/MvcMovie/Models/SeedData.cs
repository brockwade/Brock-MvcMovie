using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "When Harry Met Sally",
                         Director = "Rob Reiner",
                         ReleaseDate = DateTime.Parse("1989-1-11"),
                         Genre = "Romantic Comedy",
                         Rating = "R",
                         IMDbRating = 7.6F,
                         Price = 7.99M,
                         Poster =  "http://ia.media-imdb.com/images/M/MV5BMjE0ODEwNjM2NF5BMl5BanBnXkFtZTcwMjU2Mzg3NA@@._V1_UY1200_CR85,0,630,1200_AL_.jpg"
                     },

                     new Movie
                     {
                         Title = "Ghostbusters ",
                         Director = "Ivan Reitman",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Rating = "PG",
                         IMDbRating = 7.8F,
                         Price = 8.99M,
                         Poster = "http://netdna.walyou.netdna-cdn.com/wp-content/uploads//2011/10/Ghostbusters-Movie-Poster.jpg"
                     },

                     new Movie
                     {
                         Title = "Ghostbusters 2",
                         Director = "Ivan Reitman",
                         ReleaseDate = DateTime.Parse("1986-2-23"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Price = 9.99M,
                         IMDbRating = 6.5F,
                         Poster = "https://upload.wikimedia.org/wikipedia/en/0/01/Ghostbusters_ii_poster.jpg"
                     },

                   new Movie
                   {
                       Title = "Rio Bravo",
                       Director = "Howard Hawks",
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Genre = "Western",
                       Rating = "PG-13",
                       IMDbRating = 8.1F,
                       Price = 3.99M,
                       Poster = "http://www.doctormacro.com/Images/Posters/R/Poster%20-%20Rio%20Bravo_01.jpg"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}