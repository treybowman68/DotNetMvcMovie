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
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "PG",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Transformers",
                    ReleaseDate = DateTime.Parse("2007-7-3"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 8M
                },
                new Movie
                {
                    Title = "Transformers 2: Revenge of the Fallen",
                    ReleaseDate = DateTime.Parse("2009-6-24"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 836.5M
                },
                new Movie
                {
                    Title = "Cars",
                    ReleaseDate = DateTime.Parse("2006-6-9"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 480M
                }
            );
            context.SaveChanges();
        }
    }
}