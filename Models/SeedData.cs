using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "spiderman",
                    ReleaseDate = DateTime.Parse("2016-15-7"),
                    Genre = "sci-fi",
                    Price = 68.00M,
                    Rating = 5.0,
                },
                new Movie
                {
                    Title = "Dhamal ",
                    ReleaseDate = DateTime.Parse("2016-4-13"),
                    Genre = "Comedy",
                    Price = 90.00M,
                    
                },
                new Movie
                {
                    Title = "Bad boys",
                    ReleaseDate = DateTime.Parse("2001-15-1"),
                    Genre = "Comedy",
                    Price = 100.00M,
                    Rating = 5.0,
                },
                new Movie
                {
                    Title = "Superman",
                    ReleaseDate = DateTime.Parse("2006-5-8"),
                    Genre = "action",
                    Price = 90.00M,
                    Rating = 8.0,
                }
                new Movie
                {
                    Title = "Surya the soldier",
                    ReleaseDate = DateTime.Parse("2004-10-9"),
                    Genre = "Action",
                    Price = 200.00M,
                    Rating = 8.0,

                }
            );
            context.SaveChanges();
        }
    }
}
