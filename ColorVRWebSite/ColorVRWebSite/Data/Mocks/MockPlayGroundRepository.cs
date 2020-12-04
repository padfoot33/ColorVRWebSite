using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorVRWebSite.Data.Interfaces;
using ColorVRWebSite.Data.Models;

namespace ColorVRWebSite.Data.Mocks
{
    public class MockPlayGroundRepository : IPlayGroundRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<PlayGrounds> playGrounds 
        {
            get
            {
                return new List<PlayGrounds>
                {
                    new PlayGrounds
                    {
                        Name = "Solar System",
                        ShortDescription = "Information regarding Our Solar System",
                        LongDescription = "A 360 experience, live and learn in the first person, as an astronaut, the experience of traveling in the solar system.",
                        category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://localhost:50493/images/SolarSystem.mp4",
                        isPreferedPG = true,
                        ImageThumbnail = "http://localhost:50493/images/SolarSystemThumbNail.jpg"

                    },
                    new PlayGrounds
                    {
                        Name = "Periodic Table",
                        ShortDescription = "Information regarding The Periodic Table",
                        LongDescription = "The periodic table, also known as the periodic table of elements, arranges the chemical elements such as hydrogen, silicon, iron, and uranium according to their recurring properties.",
                        category = _categoryRepository.Categories.Last(),
                        ImageUrl = "http://localhost:50493/images/PeriodicTable.mp4",
                        isPreferedPG = true,
                        ImageThumbnail = "http://localhost:50493/images/PeriodicTableThumbNail.jpg"
                    }
                };
            }
        }

        public IEnumerable<PlayGrounds> PreferredPlayGrounds { get; }

        public PlayGrounds GetPlayerGroundById(int PGId)
        {
            throw new NotImplementedException();
        }
    }
}
