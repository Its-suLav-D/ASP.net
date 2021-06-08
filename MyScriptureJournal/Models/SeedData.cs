
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesScripture.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesScriptureContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesScriptureContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1st Nephi",
                        Chapter = "Chapter 1",
                        Verses = "3:4",
                        Notes = "Nephi Begins the Record of his people",
                        CreatedDate = DateTime.Parse("2021-06-08")
                    },
                     new Scripture
                     {
                         Book = "Jacob",
                         Chapter = "Chapter 1",
                         Verses = "3:4",
                         Notes = "Jacob and Joseph seek to persuade men to believe in Christ and keep His commandments.",
                         CreatedDate = DateTime.Parse("2021-05-07")
                     },
                      new Scripture
                      {
                          Book = "Mosiah",
                          Chapter = "Chapter 6",
                          Verses = "1:2",
                          Notes = "King Benjamin records the names of the people and appoints priests to teach them.",
                          CreatedDate = DateTime.Parse("2020-06-08")
                      }
                );
                context.SaveChanges();
            }
        }
    }
}