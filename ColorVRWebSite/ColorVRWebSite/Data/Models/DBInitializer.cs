using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorVRWebSite.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ColorVRWebSite.Data.Models
{
    public class DBInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context = applicationBuilder.GetRequiredService<AppDbContext>();
            if (!context.categories.Any())
            {
                context.categories.AddRange(Categories.Select(c => c.Value));
            }
            if (!context.playGrounds.Any())
            {
                context.AddRange(
                    new PlayGrounds
                    {
                        Name = "Solar System",
                        ShortDescription = "Information regarding Our Solar System",
                        LongDescription = "A 360 experience, live and learn in the first person, as an astronaut, the experience of traveling in the solar system.",
                        category = categories["Physics"],
                        ImageUrl = "http://localhost:50493/images/SolarSystem.mp4",
                        isPreferedPG = true,
                        ImageThumbnail = "http://localhost:50493/images/SolarSystemThumbNail.jpg"

                    },
                    new PlayGrounds
                    {
                        Name = "Periodic Table",
                        ShortDescription = "Information regarding The Periodic Table",
                        LongDescription = "The periodic table, also known as the periodic table of elements, arranges the chemical elements such as hydrogen, silicon, iron, and uranium according to their recurring properties.",
                        category = categories["Chemestry"],
                        ImageUrl = "http://localhost:50493/images/PeriodicTable.mp4",
                        isPreferedPG = true,
                        ImageThumbnail = "http://localhost:50493/images/PeriodicTableThumbNail.jpg"
                    }
                    );
            }
            context.SaveChanges();
        }
        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                         new Category { CategoryName = "Physics", Description = "Everything Related to Physics" },
                         new Category { CategoryName = "Chemestry", Description = "Everything Related to Chemestry" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }
                return categories;
            }
        }
    }
}
