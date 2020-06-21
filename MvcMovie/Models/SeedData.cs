using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
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
                        Title = "Emma Smith: My Story",
                        ReleaseDate = DateTime.Parse("2008-4-11"),
                        Genre = "Historical Drama",
                        Price = 14.99M,
                        Img = "https://d26iejr7yj7kfh.cloudfront.net/product-images/000/638/619/detail/EmmaSmithDVD5010823.jpg"
                    },

                    new Movie
                    {
                        Title = "Johnny Lingo",
                        ReleaseDate = DateTime.Parse("1969-1-1"),
                        Genre = "Family",
                        Price = 1.99M,
                        Img = "https://d2jc79253juilm.cloudfront.net/product-images/000/077/147/detail/4584865.jpg"
                    },

                    new Movie
                    {
                        Title = "The Testaments of One Fold and One Shepherd",
                        ReleaseDate = DateTime.Parse("2000-3-24"),
                        Genre = "Religious",
                        Price = 8.99M,
                        Img = "https://d2ncbdssutn1hp.cloudfront.net/product-images/000/729/959/detail/The_Testaments_DVD.jpg?1547164028"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2003-1-1"),
                        Genre = "Comedy-Drama",
                        Price = 9.99M,
                        Img = "https://d2ncbdssutn1hp.cloudfront.net/product-images/000/719/607/detail/BestTwoYears.jpg?1472572057"
                    },

                    new Movie
                    {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("2019-7-24"),
                        Genre = "Drama",
                        Price = 19.99M,
                        Img = "https://d1hdlz9ljonw49.cloudfront.net/product-images/000/734/861/detail/The_Fighting_Preacher.png?1563828994"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}